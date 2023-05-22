using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp7.DisciplineFold
{
    public partial class SearchDiscipPage
    {
        public SearchDiscipPage()
        {
            InitializeComponent();

            UpdateDiscip();
        }

        private void UpdateDiscip()
        {
            var currentDiscip = delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.ToList();

            currentDiscip = currentDiscip.Where(p => p.Name_Discipline.ToLower().Contains(DBoxSearch.Text.ToLower())).ToList();

            LViewDiscip.ItemsSource = currentDiscip.OrderBy(p => p.ID_Disciplines).ToList();
        }

        private void DBoxSearch_TextChanded(object sender, TextChangedEventArgs e)
        {
            UpdateDiscip();
        }

        private void DBoxSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void LViewDiscip_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var currentDiscip = LViewDiscip.SelectedItem as Discipline;
            if (LViewDiscip.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            else
            {
                NavigationService?.Navigate(new AddDisciplinePage(currentDiscip));
                LViewDiscip.SelectedIndex = -1;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}
