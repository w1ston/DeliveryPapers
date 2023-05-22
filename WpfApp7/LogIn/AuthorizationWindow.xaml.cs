using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace WpfApp7.LogIn
{
    public partial class AuthorizationWindow
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            LoginBox.MaxLength = 10;
            PswdBox.MaxLength = 15;
            Password.MaxLength = 15;
        }

        private void checkPas_Click(object sender, RoutedEventArgs e)
        {
            if (checkPas.IsChecked != null && checkPas.IsChecked.Value)
            {
                PswdBox.Text = Password.Password;
                PswdBox.Visibility = Visibility.Visible;
                Password.Visibility = Visibility.Hidden;
            }
            else
            {
                Password.Password = PswdBox.Text;
                PswdBox.Visibility = Visibility.Hidden;
                Password.Visibility = Visibility.Visible;
            }
        }

        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginBox.Text) || string.IsNullOrWhiteSpace(Password.Password))
            {
                MessageBox.Show("Введите все данные", "Уведомление");
            }
            else if (LoginBox.Text == "admin")
            {
                MessageBox.Show("Используйте свой логин");
            }
            else
            {
                Users user = delivery_of_term_papers_by_studentsEntities.GetContext().Users.FirstOrDefault(p => p.Login_User == LoginBox.Text);

                if (user != null && BCrypt.Net.BCrypt.Verify(Password.Password, user.passwordHash) || BCrypt.Net.BCrypt.Verify(PswdBox.Text, user.passwordHash))
                {
                    MainWindow wind1 = new MainWindow(0);

                    wind1.Show();
                    Close();

                }
                else
                {
                    MessageBox.Show("Проверьте корректность данных", "Уведомление");
                }
            }
        }

        private void LoginBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Password_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void PswdBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ChoiceUsWindow wind1 = new ChoiceUsWindow();
            wind1.Show();
            Close();
        }
    }
}
