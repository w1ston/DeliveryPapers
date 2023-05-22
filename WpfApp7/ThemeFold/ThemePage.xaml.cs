using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp7.ThemeFold
{
    public partial class ThemePage
    {
        private int count;

        const Visibility Hidden = Visibility.Hidden;
        const Visibility Visible = Visibility.Visible;

        public ThemePage(int count)
        {
            InitializeComponent();
            
            var discip = delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.ToList();
            
            discip.Insert(0, new Discipline
            {
                Name_Discipline = "Все дисциплины"
            });

            ComboDiscip.ItemsSource = discip;
            ComboDiscip.SelectedIndex = 0;
            
            this.count = count;

            AddTheme.Visibility = count == 1 ? Hidden : Visible;
            BtnDel.Visibility = count == 1 ? Hidden : Visible;
            BtnEdit.Visibility = count == 1 ? Hidden : Visible;
            BtnSearch.Visibility = count == 1 ? Hidden : Visible;
        }

        private void IsVisiblePage(object sender, DependencyPropertyChangedEventArgs e)
        {
            delivery_of_term_papers_by_studentsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var list = delivery_of_term_papers_by_studentsEntities.GetContext().Theme.ToList();
            DataGridTheme.ItemsSource = list;

        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridTheme.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить тему?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var currentTheme = DataGridTheme.SelectedItem as Theme;
                    if (currentTheme != null)
                        delivery_of_term_papers_by_studentsEntities.GetContext().Theme.Remove(currentTheme);
                    delivery_of_term_papers_by_studentsEntities.GetContext().SaveChanges();

                    DataGridTheme.ItemsSource = delivery_of_term_papers_by_studentsEntities.GetContext().Theme.ToList();
                }
            }
            else
            {
                MessageBox.Show("Выберите запись которую хотите удалить");
            }
        }
        
        private void ComboDiscip_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboDiscip.SelectedIndex == 0)
            {
                DataGridTheme.ItemsSource = GetAviableStudents();
            }
            else
            {
                var discip = ComboDiscip.SelectedItem as Discipline;
                if (discip != null)
                {
                    ICollectionView view = CollectionViewSource.GetDefaultView(DataGridTheme.ItemsSource);
                    view.Filter = s => ((Theme)s).Theme_Discipline == discip.ID_Disciplines;
                    DataGridTheme.ItemsSource = view;
                }
            }
        }
        
        private List<Theme> GetAviableStudents()
        {
            return delivery_of_term_papers_by_studentsEntities.GetContext().Theme.ToList();
        }

        private void AddTheme_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddThemePage(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var currentTheme = DataGridTheme.SelectedItem as Theme;
            if (DataGridTheme.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            else
                NavigationService?.Navigate(new AddThemePage(currentTheme));
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SearchThemePage());
        }
    }
}
