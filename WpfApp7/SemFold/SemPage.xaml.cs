using System.Linq;
using System.Windows;

namespace WpfApp7.SemFold
{
    public partial class SemPage
    {
        public SemPage()
        {
            InitializeComponent();
        }

        private void EditSem_Click(object sender, RoutedEventArgs e)
        {
            var currentSem = DataGridSem.SelectedItem as Semester;
            if (DataGridSem.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            else
                NavigationService?.Navigate(new EditSemPage(currentSem));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private void Page_IsVisiblePage(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                delivery_of_term_papers_by_studentsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGridSem.ItemsSource = delivery_of_term_papers_by_studentsEntities.GetContext().Semester.ToList();
            }
        }
    }
}
