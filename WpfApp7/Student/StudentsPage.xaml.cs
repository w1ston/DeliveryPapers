using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WpfApp7.Group;

namespace WpfApp7.Student
{
    public partial class StudentsPage
    {
        public StudentsPage()
        {
            InitializeComponent();

            var group = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();
            
            group.Insert(0, new Groups
            {
                Name_Group = "Все группы"
            });

            ComboGroup.ItemsSource = group;
            ComboGroup.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddStudent(null));
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить студента?\nУчтите, что удалятся все связанные записи с этим студентом.", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (DataGridStudents.SelectedItem is Students currentStud)
                        delivery_of_term_papers_by_studentsEntities.GetContext().Students.Remove(currentStud);
                    delivery_of_term_papers_by_studentsEntities.GetContext().SaveChanges();

                    DataGridStudents.ItemsSource =
                        delivery_of_term_papers_by_studentsEntities.GetContext().Students.ToList();
                }
            }
            else
            {
                MessageBox.Show("Выберите запись которую хотите удалить");
            }
        }

        private void BtnEdit(object sender, RoutedEventArgs e)
        {
            var currentStud = DataGridStudents.SelectedItem as Students;
            if (DataGridStudents.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            else
                NavigationService?.Navigate(new AddStudent(currentStud));
        }

        private void ComboGroup_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboGroup.SelectedIndex == 0)
            {
                DataGridStudents.ItemsSource = GetAviableStudents();
            }
            else
            {
                var group = ComboGroup.SelectedItem as Groups;
                if (group != null)
                {
                    ICollectionView view = CollectionViewSource.GetDefaultView(DataGridStudents.ItemsSource);
                    view.Filter = s => ((Students)s).ID_St_Group == group.ID_Groups;
                    DataGridStudents.ItemsSource = view;
                }
            }
        }
        
        private List<Students> GetAviableStudents()
        {
            return delivery_of_term_papers_by_studentsEntities.GetContext().Students.ToList();
        }
        
        
        private void Page_IsVisiblePage(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                delivery_of_term_papers_by_studentsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGridStudents.ItemsSource = delivery_of_term_papers_by_studentsEntities.GetContext().Students.ToList();
            }
        }

        private void BtnSearch(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SearchStudPage());
        }

        private void GoGroupEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new GroupEditPage());
        }

    }
}
