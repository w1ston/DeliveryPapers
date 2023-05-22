using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace WpfApp7.ThemeFold
{
    public partial class AddThemePage
    {
        private Theme _currentTheme = new Theme();

        public AddThemePage(Theme selectedTheme)
        {
            InitializeComponent();
            LimitedLength();

            if (selectedTheme != null)
            {
                ComboDisc.IsEnabled = false;
                EditTheme(selectedTheme);
            }

            var listDisc = delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.ToList();
            ComboDisc.ItemsSource = listDisc;

            if (selectedTheme != null)
            {
                var disc = listDisc.Where(g => g.ID_Disciplines.Equals(selectedTheme.Theme_Discipline));
                if (disc.Count() > 0)
                    ComboDisc.SelectedValue = disc.First();
            }

            DataContext = _currentTheme;
        }

        private void NameTheme_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
            
        }

        private void LimitedLength()
        {
            NameTheme.MaxLength = 150;
        }

        private void EditTheme(Theme theme)
        {
            _currentTheme = theme;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (ComboDisc.SelectedItem is Discipline selDiscipline)
            {
                _currentTheme.Theme_Discipline = selDiscipline.ID_Disciplines;
            }

            if (_currentTheme.ID_Theme == 0)
            {
                Theme theme = delivery_of_term_papers_by_studentsEntities.GetContext().Theme.FirstOrDefault(p => p.Name_Theme == NameTheme.Text);
                if (theme != null)
                {
                    errors.AppendLine("Такая тема уже существует");
                }
            }

            if (_currentTheme.Theme_Discipline == 0)
                errors.AppendLine("Выберите дисциплину");
            if (string.IsNullOrWhiteSpace(_currentTheme.Name_Theme))
                errors.AppendLine("Введите название темы");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentTheme.ID_Theme == 0)
                delivery_of_term_papers_by_studentsEntities.GetContext().Theme.Add(_currentTheme);

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
