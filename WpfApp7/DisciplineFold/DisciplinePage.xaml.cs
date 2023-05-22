using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;

namespace WpfApp7.DisciplineFold
{
    public partial class DisciplinePage
    {
        public DisciplinePage()
        {
            InitializeComponent();
        }

        private void Page_IsVisiblePage(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                delivery_of_term_papers_by_studentsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGridDiscip.ItemsSource = delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.ToList();
            }
        }

        private void AddDiscip_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddDisciplinePage(null));
        }

        private void EditDiscip_Click(object sender, RoutedEventArgs e)
        {
            var currentDiscip = DataGridDiscip.SelectedItem as Discipline;
            if (DataGridDiscip.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            else
                NavigationService?.Navigate(new AddDisciplinePage(currentDiscip));
        }

        private void DelDiscip_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridDiscip.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить дисциплину? \nУчтите, что при удалении дисциплины, удалятся все записи связанный с этой дисциплиной.", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var currentDiscip = DataGridDiscip.SelectedItem as Discipline;
                    if (currentDiscip != null)
                        delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.Remove(currentDiscip);
                    delivery_of_term_papers_by_studentsEntities.GetContext().SaveChanges();

                    DataGridDiscip.ItemsSource = delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.ToList();
                }
            }
            else
            {
                MessageBox.Show("Выберите запись которую хотите удалить");
            }
        }
        private void SearchDiscip_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SearchDiscipPage());
        }
    }
}
