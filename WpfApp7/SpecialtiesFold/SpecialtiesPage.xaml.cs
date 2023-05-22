using System.Linq;
using System.Windows;

namespace WpfApp7.SpecialtiesFold
{
    public partial class SpecialtiesPage
    {
        public SpecialtiesPage()
        {
            InitializeComponent();
        }

        private void AddSpec_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddSpecPage(null));
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridSpecial.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить специальность? \nУчтите, что при удалении специальности, удалятся все связанные записи с ней.", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var currentSpec = DataGridSpecial.SelectedItem as Specialties;
                    if (currentSpec != null)
                        delivery_of_term_papers_by_studentsEntities.GetContext().Specialties.Remove(currentSpec);
                    delivery_of_term_papers_by_studentsEntities.GetContext().SaveChanges();

                    DataGridSpecial.ItemsSource =
                        delivery_of_term_papers_by_studentsEntities.GetContext().Specialties.ToList();
                }
            }
            else
            {
                MessageBox.Show("Выберите запись которую хотите удалить");
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var currentSpec = DataGridSpecial.SelectedItem as Specialties;
            if (DataGridSpecial.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            else
                NavigationService?.Navigate(new AddSpecPage(currentSpec));
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SearchSpecPage());
        }

        private void IsVisiblePage(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                delivery_of_term_papers_by_studentsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGridSpecial.ItemsSource = delivery_of_term_papers_by_studentsEntities.GetContext().Specialties.ToList();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}
