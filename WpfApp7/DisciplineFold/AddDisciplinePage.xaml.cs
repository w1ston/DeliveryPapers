using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace WpfApp7.DisciplineFold
{
    public partial class AddDisciplinePage
    {
        private Discipline _currentDiscip = new Discipline();

        public AddDisciplinePage(Discipline selectedDiscip)
        {
            InitializeComponent();
            LengthLimit();

            if (selectedDiscip != null)
            {
                EditDiscip(selectedDiscip);
            }

            DataContext = _currentDiscip;
        }

        private void LengthLimit()
        {
            DDiscip.MaxLength = 20;
        }

        private void EditDiscip(Discipline selectedDiscip)
        {
            _currentDiscip = selectedDiscip;
        }

        private void DDiscip_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            Discipline discip = delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.FirstOrDefault(p => p.Name_Discipline == DDiscip.Text);

            if (_currentDiscip.ID_Disciplines == 0)
            {
                if (discip != null)
                {
                    errors.AppendLine("Такая дисциплина уже есть");
                }
            }

            if (string.IsNullOrWhiteSpace(_currentDiscip.Name_Discipline))
                errors.AppendLine("Введите название дисциплины");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentDiscip.ID_Disciplines == 0)
                delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.Add(_currentDiscip);

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
