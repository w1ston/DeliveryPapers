using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace WpfApp7.LogIn
{
    public partial class ChoiceStud
    {
        public ChoiceStud()
        {
            InitializeComponent();
            ChoiceCard.MaxLength = 15;
        }

        private void CheckStud_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChoiceCard.Text))
            {
                MessageBox.Show("Введите номер зачётной книжки", "Уведомление");
            }
            else
            {
                Students stud = delivery_of_term_papers_by_studentsEntities.GetContext().Students.FirstOrDefault(p => p.St_ID_Card.ToString() == ChoiceCard.Text);

                if (stud != null)
                {
                    int count = 1;
                    MainWindow wind = new MainWindow(count);
                    wind.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Заченая книжка не найдена", "Уведомление");
                }
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ChoiceUsWindow wind = new ChoiceUsWindow();
            wind.Show();
            Close();
        }

        private void ChoiceCard_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
