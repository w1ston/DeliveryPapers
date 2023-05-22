using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp7.Rules;

namespace WpfApp7.ChoiceThemeFold
{
    public partial class SelThemeWindow
    {
        private readonly List _currentList = new List();

        private readonly ChoiceThemePage _parentPage;

        private readonly string _selDiscip;

        public SelThemeWindow(Theme selectedTheme, ChoiceThemePage parentPage, string selectedDiscipName)
        {
            InitializeComponent();
            x1.Content = "Выбранная дисциплина: " + selectedDiscipName;
            
            var group = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();

            this._selDiscip = selectedDiscipName;
            
            group.Insert(0, new Groups
            {
                Name_Group = "Все группы"
            });
            NameGroupp.ItemsSource = group;
            NameGroupp.SelectedIndex = 0;

            DataContext = _currentList;

            selectedTheme.ID_Selected_Theme = selectedTheme.ID_Theme;
            _currentList.ID_Theme = selectedTheme.ID_Theme;
            _currentList.ID_Disciline = selectedTheme.Theme_Discipline;
            
            UpdateStudent();

            this._parentPage = parentPage;
            Closing += SelThemeWindow_Closing;
        }

        private void NameGroupp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateStudent();
            
            var selectedDiscipline = _selDiscip;
            var filter = FiltereDisciplinesGroup(selectedDiscipline);

            NameGroupp.ItemsSource = filter;
        }
        
        private List<Groups> FiltereDisciplinesGroup(string disciplineName)
        {
            GroupDisciplineValidator validator = new GroupDisciplineValidator("C:/Users/Валерий/source/repos/WpfApp7/WpfApp7/Rules/GroupsDisciplinesRules.json");
            var group = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();

            var filteredGroups = group
                .Where(d => validator.IsGroupDisciplineValid(d.Name_Group, disciplineName)).ToList();

            filteredGroups.Insert(0, new Groups
            {
                Name_Group = "Все группы"
            });
            return filteredGroups;
        }

        private void UpdateStudent()
        {
            var dbContext = delivery_of_term_papers_by_studentsEntities.GetContext();
            var selectedGroup = NameGroupp.SelectedItem as Groups;
            var selectedGroupIndex = NameGroupp.SelectedIndex;
            
            if (selectedGroup == null)
            {
                return;
            }

            if (selectedGroupIndex == 0)
            {
                var studentList = dbContext.List.ToList();
                var excludeStud = studentList.Where(p => p.Student_ID.HasValue).Select(p => p.Student_ID.Value)
                    .ToList();
                var allStudent = dbContext.Students.Where(s => !excludeStud.Contains(s.ID_Student)).ToList();
                
                DataInStudent.ItemsSource = allStudent;
                DataInStudent.DataContext = allStudent;
            }
            else
            {
                var currentList = dbContext.List.ToList();
                var excludeIds = currentList.Where(p => p.Student_ID.HasValue).Select(p => p.Student_ID.Value).ToList();
                var studentInGroup = dbContext.Students.Where(s => s.ID_St_Group == selectedGroup.ID_Groups && !excludeIds.Contains(s.ID_Student)).ToList();

                DataInStudent.ItemsSource = studentInGroup;
                DataInStudent.DataContext = studentInGroup;
            }
        }

        private void DataInStudent_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DataInStudent.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента");
            }
            else
            {
                var selectedThemes = delivery_of_term_papers_by_studentsEntities.GetContext().Theme.ToList();

                if (DataInStudent.SelectedItem is Students selStud)
                {
                    _currentList.Student_ID = selStud.ID_Student;
                    var selectedTheme = selectedThemes.FirstOrDefault(t => t.ID_Theme == _currentList.ID_Theme);

                    GroupDisciplineValidator validator = new GroupDisciplineValidator(
                        "C:/Users/Валерий/source/repos/WpfApp7/WpfApp7/Rules/GroupsDisciplinesRules.json");
                    var selectedGroupName = selStud.Groups.Name_Group;
                    string selectedDiscipName = _selDiscip;

                    bool isValid = validator.IsGroupDisciplineValid(selectedGroupName, selectedDiscipName);

                    if (!isValid)
                    {
                        MessageBox.Show("Группа не содержит такой дисциплины");
                    }
                    else
                    {
                        _currentList.Theme = selectedTheme;
                        if (_currentList.Theme != null)
                            if (selectedTheme != null)
                                _currentList.Theme.ID_Selected_Theme = selectedTheme.ID_Theme;

                        if (_currentList.ID_List == 0)
                        {
                            delivery_of_term_papers_by_studentsEntities.GetContext().List.Add(_currentList);
                        }

                        try
                        {
                            delivery_of_term_papers_by_studentsEntities.GetContext().SaveChanges();
                            MessageBox.Show("Информация сохранена");
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void SelThemeWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _parentPage.RefreshThemes();
            _parentPage.Visibility = Visibility.Visible;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
