using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp7.SpecialtiesFold
{
    public partial class SearchSpecPage
    {
        public SearchSpecPage()
        {
            InitializeComponent();

            UpdateSpec();
        }

        private void SViewTheme_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var currenSpec = LViewSpec.SelectedItem as Specialties;
            if (LViewSpec.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            else
            {
                NavigationService?.Navigate(new AddSpecPage(currenSpec));
                LViewSpec.SelectedIndex = -1;
            }
        }

        private void UpdateSpec()
        {
            var currentSpec = delivery_of_term_papers_by_studentsEntities.GetContext().Specialties.ToList();

            currentSpec = currentSpec.Where(p => p.Name_Specialties.ToLower().Contains(SBoxSearch.Text.ToLower())).ToList();

            LViewSpec.ItemsSource = currentSpec.OrderBy(p => p.ID_Specialties).ToList();
        }

        private void SBoxSearch_TextChanded(object sender, TextChangedEventArgs e)
        {
            UpdateSpec();
        }

        private void SBoxSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}
