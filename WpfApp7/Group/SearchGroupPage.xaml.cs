using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp7.Group
{
    public partial class SearchGroupPage
    {
        public SearchGroupPage()
        {
            InitializeComponent();

            var spec = delivery_of_term_papers_by_studentsEntities.GetContext().Specialties.ToList();

            spec.Insert(0, new Specialties
            {
                Name_Specialties = "Все специальности"
            });

            ComboSpec.ItemsSource = spec;
            ComboSpec.SelectedIndex = 0;

            UpdateGroup();
        }

        private void UpdateGroup()
        {
            var currentGroup = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();

            currentGroup = currentGroup.Where(p => p.Name_Group.ToLower().Contains(GBoxSearch.Text.ToLower())).ToList();

            if (ComboSpec.SelectedIndex > 0)
            {
                var selectedSpec = (Specialties)ComboSpec.SelectedItem;
                var groupInSpec = currentGroup.Where(s => s.Speciality == selectedSpec.ID_Specialties);
                currentGroup = groupInSpec.ToList();
            }

            LViewTheme.ItemsSource = currentGroup.OrderBy(p => p.Speciality).ToList();
        }

        private void GBoxSearch_TextChanded(object sender, TextChangedEventArgs e)
        {
            UpdateGroup();
        }

        private void GBoxSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ComboSpec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateGroup();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private void GViewTheme_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var currentGroup = LViewTheme.SelectedItem as Groups;
            if (LViewTheme.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            else
            {
                NavigationService?.Navigate(new AddGroupPage(currentGroup));
                LViewTheme.SelectedIndex = -1;
            }
        }
    }
}
