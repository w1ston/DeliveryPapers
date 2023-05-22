using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace WpfApp7.SemFold
{
    public partial class EditSemPage
    {
        private Semester _currentSem;

        public EditSemPage(Semester selectedSem)
        {
            InitializeComponent();

            _currentSem = selectedSem;
            DataContext = _currentSem;

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (!NYear.SelectedDate.HasValue)
            {
                errors.AppendLine("Введите дату");
            }
            else
            {
                int year = NYear.SelectedDate.Value.Year;

                using (var context = new delivery_of_term_papers_by_studentsEntities())
                {
                    var sem = context.Semester.FirstOrDefault(p => p.Semester_Year.HasValue && p.Semester_Year.Value.Year == year);
                    if (sem != null)
                    {
                        errors.AppendLine("Такой год уже есть");
                    }
                    else
                    {
                        sem = context.Semester.FirstOrDefault();
                        if (sem != null)
                            sem.Semester_Year = NYear.SelectedDate;
                        context.SaveChanges();
                    }
                }
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            MessageBox.Show("Информация сохранена");
            NavigationService?.GoBack();
        }

        private void NYear_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

    }
}
