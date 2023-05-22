using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace WpfApp7.Student
{
    public partial class AddStudent
    {
        private Students _currentStud = new Students();

        public AddStudent(Students selectedStudent)
        {
            InitializeComponent();
            LimitedLength();

            if (selectedStudent != null)
            {
                IdCard.IsEnabled = false;
                EditStud(selectedStudent);
            }


            var listGroups = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();
            ComboGroups.ItemsSource = listGroups;

            if (selectedStudent != null)
            {
                var group = listGroups.Where(g => g.ID_Groups.Equals(selectedStudent.ID_St_Group));
                var groupsEnumerable = group as Groups[] ?? group.ToArray();
                if (groupsEnumerable.Any())
                    ComboGroups.SelectedValue = groupsEnumerable.First();
            }

            DataContext = _currentStud;
        }

        private void EditStud(Students students)
        {
            _currentStud = students;
        }

        private void LimitedLength()
        {
            IdCard.MaxLength = 15;
            Sur.MaxLength = 15;
            Name.MaxLength = 15;
            Pat.MaxLength = 15;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            Students user = delivery_of_term_papers_by_studentsEntities.GetContext().Students.FirstOrDefault(p => p.St_ID_Card.ToString() == IdCard.Text);

            if (ComboGroups.SelectedItem is Groups selGroup)
            {
                _currentStud.ID_St_Group = selGroup.ID_Groups;
            }

            if (_currentStud.St_ID_Card == 0)
            {
                errors.AppendLine("Введите номер зачетной книжки");
            }

            if (_currentStud.ID_Student == 0)
            {
                if (user != null)
                {
                    errors.AppendLine("Такой номер зачетной книжки уже есть");
                }
            }

            if (_currentStud.ID_St_Group == 0)
                errors.AppendLine("Выберите группу");
            if (string.IsNullOrWhiteSpace(_currentStud.St_Surname))
                errors.AppendLine("Введите фамилию студента");
            if (string.IsNullOrWhiteSpace(_currentStud.St_Name))
                errors.AppendLine("Введите имя студента");
            if (string.IsNullOrWhiteSpace(_currentStud.St_Patronymic))
                errors.AppendLine("Введите отчество студента");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentStud.ID_Student == 0)
                delivery_of_term_papers_by_studentsEntities.GetContext().Students.Add(_currentStud);

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

        private void IdCard_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Sur_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Pat_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
