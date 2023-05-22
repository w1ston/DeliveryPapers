using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace WpfApp7.LogIn
{
    public partial class RegWindow
    {
        private Users _currentUser = new Users();

        public enum PasswordStrength
        {
            Weak,
            Medium,
            Strong
        }

        public RegWindow()
        {
            InitializeComponent();

            DataContext = _currentUser;

            LoginBox.MaxLength = 10;
            PswdBox.MaxLength = 15;
            Password.MaxLength = 15;
            SurUser.MaxLength = 25;
            NameUs.MaxLength = 25;
            PatUs.MaxLength = 25;

            buttonReg.IsEnabled = false;

            lblWeakPassword.Visibility = Visibility.Hidden;
            lblNormalPassword.Visibility = Visibility.Hidden;
            lblStrongPassword.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dbContext = delivery_of_term_papers_by_studentsEntities.GetContext();
            Users user = dbContext.Users.FirstOrDefault(p => p.Login_User == LoginBox.Text);
            StringBuilder errors = new StringBuilder();

            string password = string.IsNullOrEmpty(Password.Password) ? PswdBox.Text : Password.Password;

            if (string.IsNullOrWhiteSpace(_currentUser.Login_User))
                errors.AppendLine("Введите логин");
            if (user != null)
                errors.AppendLine("Такой логин уже существует");
            if (string.IsNullOrWhiteSpace(password))
                errors.AppendLine("Введите пароль");
            if (string.IsNullOrWhiteSpace(_currentUser.Surname))
                errors.AppendLine("Введите вашу фамилию");
            if (string.IsNullOrWhiteSpace(_currentUser.Name))
                errors.AppendLine("Введите ваше имя");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentUser.Id_User == 0)
            {
                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                _currentUser.passwordHash = BCrypt.Net.BCrypt.HashPassword(password, salt);
                dbContext.Users.Add(_currentUser);
            }

            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Успешная регистрация", "Уведомление");
                MainWindow wind1 = new MainWindow(0);
                wind1.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkPas_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
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

        private PasswordStrength CheckPasswordStrength(string password)
        {
            int score = 0;

            if (password.Length > 6)
                buttonReg.IsEnabled = true;
            else
                buttonReg.IsEnabled = false;

            if (password.Length < 6)
                return PasswordStrength.Weak;

            else if (password.Length >= 8 && password.Length <= 10)
                score++;

            else if (password.Length >= 11 && password.Length <= 13)
                score += 2;

            else if (password.Length >= 14)
                score += 3;

            if (Regex.IsMatch(password, @"\d"))
                score++;

            if (Regex.IsMatch(password, "[A-Z]"))
                score++;

            if (Regex.IsMatch(password, "[a-z]"))
                score++;

            if (Regex.IsMatch(password, @"[!@#$%^&*()_+{}\[\]:;<>,.?\/-=]"))
                score++;

            if (score < 5)
                return PasswordStrength.Weak;

            else if (score < 7)
                return PasswordStrength.Medium;

            else
                return PasswordStrength.Strong;

        }

        private void SetLabelColor(Label label, bool show)
        {
            if (show)
                label.Visibility = Visibility.Visible;
            else
                label.Visibility = Visibility.Collapsed;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wind1 = new MainWindow(0);
            wind1.Show();
            Close();
        }

        private void LoginBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void NameUs_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SurUser_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void PatUs_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordStrength passwordStrength;

            if (checkPas.IsChecked != null && checkPas.IsChecked.Value)
            {
                passwordStrength = CheckPasswordStrength(PswdBox.Text);

                if (string.IsNullOrEmpty(PswdBox.Text))
                {
                    SetLabelColor(lblWeakPassword, false);
                    SetLabelColor(lblNormalPassword, false);
                    SetLabelColor(lblStrongPassword, false);
                    return;
                }
            }
            else
            {
                passwordStrength = CheckPasswordStrength(Password.Password);

                if (string.IsNullOrEmpty(Password.Password))
                {
                    SetLabelColor(lblWeakPassword, false);
                    SetLabelColor(lblNormalPassword, false);
                    SetLabelColor(lblStrongPassword, false);
                    return;
                }
            }

            switch (passwordStrength)
            {
                case PasswordStrength.Weak:
                    SetLabelColor(lblWeakPassword, true);
                    SetLabelColor(lblNormalPassword, false);
                    SetLabelColor(lblStrongPassword, false);
                    break;
                case PasswordStrength.Medium:
                    SetLabelColor(lblWeakPassword, false);
                    SetLabelColor(lblNormalPassword, true);
                    SetLabelColor(lblStrongPassword, false);
                    break;
                case PasswordStrength.Strong:
                    SetLabelColor(lblWeakPassword, false);
                    SetLabelColor(lblNormalPassword, false);
                    SetLabelColor(lblStrongPassword, true);
                    break;
            }
        }

        private void Pswd_TextChanged(object sender, TextChangedEventArgs e)
        {
            Password_PasswordChanged(null, null);
        }
    }
}
