using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp7.Student
{
    public partial class SearchStudPage
    {


        public SearchStudPage()
        {
            InitializeComponent();
            var group = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();

            group.Insert(0, new Groups
            {
                Name_Group = "Все группы"
            });

            ComboGroups.ItemsSource = group;
            ComboGroups.SelectedIndex = 0;

            UpdateStudent();
        }

        private void UpdateStudent()
        {
            var currentStud = delivery_of_term_papers_by_studentsEntities.GetContext().Students.ToList();

            currentStud = currentStud.Where(p => p.St_ID_Card.ToString().ToLower().Contains(SBoxSearch.Text.ToLower())).ToList();

            if (ComboGroups.SelectedIndex > 0)
            {
                var selectedGroup = (Groups)ComboGroups.SelectedItem;
                var studentsInGroup = currentStud.Where(s => s.ID_St_Group == selectedGroup.ID_Groups);
                currentStud = studentsInGroup.ToList();
            }

            currentStud = currentStud.Where(p => p.St_Name.ToString().ToLower().Contains(SNameSearch.Text.ToLower())).ToList();
            currentStud = currentStud.Where(p => p.St_Surname.ToLower().Contains(SsurStud.Text.ToLower())).ToList();
            currentStud = currentStud.Where(p => p.St_Patronymic.ToLower().Contains(SPatSearch.Text.ToLower())).ToList();

            LViewStud.ItemsSource = currentStud.OrderBy(p => p.St_ID_Card).ToList();
        }

        private void SBoxSearch_TextChanded(object sender, TextChangedEventArgs e)
        {
            UpdateStudent();
        }

        private void ComboGroups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateStudent();
        }

        private void SBoxSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SNameSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SsurStud_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SPatSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void LViewStud_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var currentStud = LViewStud.SelectedItem as Students;
            if (LViewStud.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            else
            {
                NavigationService?.Navigate(new AddStudent(currentStud));
                LViewStud.SelectedIndex = -1;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}
