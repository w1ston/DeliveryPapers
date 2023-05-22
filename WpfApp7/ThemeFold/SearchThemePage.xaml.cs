using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp7.ThemeFold
{
    public partial class SearchThemePage
    {
        public SearchThemePage()
        {
            InitializeComponent();

            var disc = delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.ToList();

            disc.Insert(0, new Discipline
            {
                Name_Discipline = "Все дисциплины"
            });

            ComboDisc.ItemsSource = disc;
            ComboDisc.SelectedIndex = 0;

            UpdateTheme();
        }

        private void UpdateTheme()
        {
            var currentTheme = delivery_of_term_papers_by_studentsEntities.GetContext().Theme.ToList();

            currentTheme = currentTheme.Where(p => p.Name_Theme.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            if (ComboDisc.SelectedIndex > 0)
            {
                var selectedDisc = (Discipline)ComboDisc.SelectedItem;
                var themeInDisc = currentTheme.Where(s => s.Theme_Discipline == selectedDisc.ID_Disciplines);
                currentTheme = themeInDisc.ToList();
            }

            LViewTheme.ItemsSource = currentTheme.OrderBy(p => p.Theme_Discipline).ToList();
        }

        private void TBoxSearch_TextChanded(object sender, TextChangedEventArgs e)
        {
            UpdateTheme();
        }

        private void ComboDisc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTheme();
        }

        private void TViewTheme_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var currentTheme = LViewTheme.SelectedItem as Theme;
            if (LViewTheme.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            else
            {
                NavigationService?.Navigate(new AddThemePage(currentTheme));
                LViewTheme.SelectedIndex = -1;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private void TBoxSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
