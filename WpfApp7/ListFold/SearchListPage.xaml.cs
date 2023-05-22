using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp7.ListFold
{
    public partial class SearchListPage
    {
        public SearchListPage()
        {
            InitializeComponent();

            var group = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();

            group.Insert(0, new Groups
            {
                Name_Group = "Все группы"
            });

            ComboGroup.ItemsSource = group;
            ComboGroup.SelectedIndex = 0;

            UpdateList();

            TBoxSearch.MaxLength = 25;
            SBoxSearch.MaxLength = 25;
            SSBoxSearch.MaxLength = 25;
        }

        private void UpdateList()
        {
            var currentList = delivery_of_term_papers_by_studentsEntities.GetContext().List.ToList();

            currentList = currentList.Where(p => p.Theme.Name_Theme.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            currentList = currentList.Where(p => p.Students.St_Name.ToLower().Contains(SBoxSearch.Text.ToLower())).ToList();
            currentList = currentList.Where(p => p.Students.St_Surname.ToLower().Contains(SSBoxSearch.Text.ToLower())).ToList();

            if (ComboGroup.SelectedIndex > 0)
            {
                var selectedGroup = (Groups)ComboGroup.SelectedItem;
                var groupInList = currentList.Where(s => s.Students.Groups.ID_Groups == selectedGroup.ID_Groups);
                currentList = groupInList.ToList();
            }

            LViewList.ItemsSource = currentList.OrderBy(p => p.ID_List).ToList();
        }

        private void ComboGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }

        private void TBoxSearch_TextChanded(object sender, TextChangedEventArgs e)
        {
            UpdateList();
        }

        private void SBoxSearch_TextChanded(object sender, TextChangedEventArgs e)
        {
            UpdateList();
        }

        private void SSBoxSearch_TextChanded(object sender, TextChangedEventArgs e)
        {
            UpdateList();
        }

        private void TBoxSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        private void SBoxSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SSBoxSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TViewTheme_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var currentList = LViewList.SelectedItem as List;
            if (LViewList.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования данных");
            }
            else
                NavigationService?.Navigate(new AddListPage(currentList));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

    }
}
