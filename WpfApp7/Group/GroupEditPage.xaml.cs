using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp7.SpecialtiesFold;

namespace WpfApp7.Group
{
    public partial class GroupEditPage : Page
    {
        public GroupEditPage()
        {
            InitializeComponent();
        }

        private void SearchGroup_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SearchGroupPage());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddGroupPage(null));
        }

        private void EditGroup_Click(object sender, RoutedEventArgs e)
        {
            var currentGroup = DataGridGroups.SelectedItem as Groups;
            if (DataGridGroups.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            else
                NavigationService?.Navigate(new AddGroupPage(currentGroup));
        }

        private void DelGroup_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridGroups.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить группу? \nУчтите, что при удалении группы, удалятся все записи связанный с этой группой.", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var currentGroup = DataGridGroups.SelectedItem as Groups;
                    if (currentGroup != null)
                        delivery_of_term_papers_by_studentsEntities.GetContext().Groups.Remove(currentGroup);
                    delivery_of_term_papers_by_studentsEntities.GetContext().SaveChanges();

                    DataGridGroups.ItemsSource = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();
                }
            }
            else
            {
                MessageBox.Show("Выберите запись которую хотите удалить");
            }
        }


        private void GoSpec_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SpecialtiesPage());
        }

        private void Page_IsVisiblePage(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                delivery_of_term_papers_by_studentsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGridGroups.ItemsSource = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();
            }
        }
    }
}
