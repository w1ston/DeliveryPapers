using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace WpfApp7.Group
{
    public partial class AddGroupPage
    {

        private Groups _currentGroup = new Groups();

        public AddGroupPage(Groups selectedGroup)
        {
            InitializeComponent();
            LengthLimit();

            if (selectedGroup != null)
            {
                EditGroup(selectedGroup);
            }

            var listSpec = delivery_of_term_papers_by_studentsEntities.GetContext().Specialties.ToList();
            ComboSpec.ItemsSource = listSpec;

            if (selectedGroup != null)
            {
                var spec = listSpec.Where(g => g.ID_Specialties.Equals(selectedGroup.Speciality));
                if (spec.Count() > 0)
                    ComboSpec.SelectedValue = spec.First();
            }

            DataContext = _currentGroup;
        }

        private void EditGroup(Groups selectedGroup)
        {
            _currentGroup = selectedGroup;
        }

        private void LengthLimit()
        {
            NGroup.MaxLength = 5;
        }

        private void NGroup_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            Groups group = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.FirstOrDefault(p => p.Name_Group == NGroup.Text);

            if (ComboSpec.SelectedItem is Specialties selSpec)
            {
                _currentGroup.Speciality = selSpec.ID_Specialties;
            }

            if (_currentGroup.ID_Groups == 0)
            {
                if (group != null)
                {
                    errors.AppendLine("Такая группа уже есть");
                }
            }

            if (_currentGroup.Speciality == 0)
                errors.AppendLine("Выберите специальность");
            if (string.IsNullOrWhiteSpace(_currentGroup.Name_Group))
                errors.AppendLine("Введите название группы (аббревиатуру)");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentGroup.ID_Groups == 0)
                delivery_of_term_papers_by_studentsEntities.GetContext().Groups.Add(_currentGroup);

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
    }
}
