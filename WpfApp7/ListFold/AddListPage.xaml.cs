using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace WpfApp7.ListFold
{
    public partial class AddListPage
    {
        private List _currentList;

        public AddListPage(List selectedList)
        {
            InitializeComponent();

            var listGroups = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();
            ComboGroups.ItemsSource = listGroups;

            var group = listGroups.Where(g => g.ID_Groups.Equals(selectedList.Students.ID_St_Group));
            ComboGroups.SelectedValue = group.First();

            var listSem = delivery_of_term_papers_by_studentsEntities.GetContext().Semester.ToList();

            if (selectedList.Half_Year != null)
            {
                var sem = listSem.Where(g => g.ID_Semester.Equals(selectedList.Half_Year));
                ComboSem.SelectedValue = sem.First();
            }

            ComboSem.ItemsSource = listSem;

            _currentList = selectedList;

            DataContext = _currentList;

            SymbolLength();
        }

        private void SymbolLength()
        {
            GradeL.MaxLength = 1;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (ComboSem.SelectedItem is Semester selSem)
            {
                _currentList.Half_Year = selSem.ID_Semester;
            }

            var selTime = datatime.SelectedDate;

            _currentList.Work_submition_date = selTime.GetValueOrDefault();

            if (_currentList.Half_Year == 0)
                errors.AppendLine("Выберите семестр");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                delivery_of_term_papers_by_studentsEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService?.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private void Grade_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^2-5]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
