using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using WpfApp7.Rules;
using WpfApp7.ThemeFold;

namespace WpfApp7.ChoiceThemeFold
{
    public partial class ChoiceThemePage
    {
        private readonly int _count;

        const Visibility Hidden = Visibility.Hidden;
        const Visibility Visible = Visibility.Visible;

        public ChoiceThemePage(int count)
        {
            InitializeComponent();
            RefreshThemes();

            this._count = count;

            label1.Visibility = count == 1 ? Hidden : Visible;
            label2.Visibility = count == 1 ? Hidden : Visible;
            NLabel.Visibility = count == 1 ? Hidden : Visible;
            Ngroup.Visibility = count == 1 ? Hidden : Visible;
            SearchTheme.Visibility = count == 1 ? Hidden : Visible;
            RandomTheme.Visibility = count == 1 ? Hidden : Visible;
            DataUnStudent.Visibility = count == 1 ? Hidden : Visible;

            if (count == 1)
            {
                DataUnSelectedTheme.HorizontalAlignment = HorizontalAlignment.Center;
                NDiscipline.Margin = new Thickness(0, 3, 0, 0);
                NLabelDisc.Margin = new Thickness(340, 16, 0, 0);
            }
            else
            {
                DataUnSelectedTheme.HorizontalAlignment = HorizontalAlignment.Right;
                NDiscipline.Margin = new Thickness(670, 3, 0, 0);
                NLabelDisc.Margin = new Thickness(671, 16, 0, 0);
            }

            var group = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();
            var discip = delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.ToList();

            group.Insert(0, new Groups
            {
                Name_Group = "Все группы"
            });

            Ngroup.ItemsSource = group;
            Ngroup.SelectedIndex = 0;

            discip.Insert(0, new Discipline
            {
                Name_Discipline = "Все дисциплины"
            });

            NDiscipline.ItemsSource = discip;
            NDiscipline.SelectedIndex = 0;
        }

        public void RefreshThemes()
        {
            delivery_of_term_papers_by_studentsEntities.GetContext().ChangeTracker.Entries().ToList()
                .ForEach(p => p.Reload());

            var currentStud = delivery_of_term_papers_by_studentsEntities.GetContext().Students.ToList();
            var currentList = delivery_of_term_papers_by_studentsEntities.GetContext().List.ToList();

            var excludedIds = currentList.Where(p => p.Student_ID.HasValue).Select(p => p.Student_ID.Value).ToList();
            currentStud = currentStud.Where(s => !excludedIds.Contains(s.ID_Student)).ToList();

            DataUnStudent.ItemsSource = currentStud;
            DataUnSelectedTheme.ItemsSource = delivery_of_term_papers_by_studentsEntities.GetContext().Theme
                .Where(p => p.ID_Selected_Theme == null).ToList();
        }

        private void SearchTheme_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SearchThemePage());
        }

        private void DataUnSelectedTheme_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (_count != 1)
            {
                if (DataUnSelectedTheme.SelectedItem != null)
                {
                    var selectedTheme = DataUnSelectedTheme.SelectedItem as Theme;
                    if (selectedTheme != null)
                    {
                        var selectedDiscipline = delivery_of_term_papers_by_studentsEntities.GetContext().Discipline
                            .FirstOrDefault(x => x.ID_Disciplines == selectedTheme.Theme_Discipline);
                        if (selectedDiscipline != null)
                        {
                            SelThemeWindow wind =
                                new SelThemeWindow(selectedTheme, this, selectedDiscipline.Name_Discipline);
                            Pages.Visibility = Visibility.Hidden;
                            wind.ShowDialog();
                        }
                    }

                    DataUnSelectedTheme.SelectedIndex = -1;
                }
            }
        }

        private void RandomTheme_Click(object sender, RoutedEventArgs e)
        {
            var context = delivery_of_term_papers_by_studentsEntities.GetContext();

            var studentsWithoutThemes = context.Students
                .Where(s => !context.List.Any(l => l.Student_ID == s.ID_Student && l.ID_Theme != null))
                .ToList();

            if (studentsWithoutThemes.Any())
            {
                var selectedThemes = context.Theme
                    .Where(t => t.ID_Selected_Theme == null)
                    .ToList();

                int selectedGroupIndex = Ngroup.SelectedIndex;
                int selectedDiscipIndex = NDiscipline.SelectedIndex;

                if (selectedGroupIndex > 0)
                {
                    var selectedGroup = (Groups)Ngroup.SelectedItem;
                    studentsWithoutThemes = studentsWithoutThemes
                        .Where(s => s.Groups.Name_Group == selectedGroup.Name_Group)
                        .ToList();
                }

                if (selectedDiscipIndex > 0)
                {
                    var selectedDiscipline = (Discipline)NDiscipline.SelectedItem;
                    string selectedDiscipName = selectedDiscipline.Name_Discipline;
                    selectedThemes = selectedThemes
                        .Where(t => t.Discipline.Name_Discipline == selectedDiscipName)
                        .ToList();
                }

                if (selectedThemes.Any())
                {
                    var groupCount = studentsWithoutThemes.GroupBy(s => s.Groups.Name_Group)
                        .ToDictionary(g => g.Key, g => g.Count());
                    var themeCount = selectedThemes.ToDictionary(t => t.ID_Theme, t => 0);

                    List<int> selectedThemeId = new List<int>();

                    foreach (var student in studentsWithoutThemes)
                    {
                        var studentGroup = student.Groups;
                        if (studentGroup != null)
                        {
                            string selectedGroupName = studentGroup.Name_Group;
                            if (groupCount[selectedGroupName] > 0)
                            {
                                var validTheme = new List<Theme>();
                                foreach (var theme in selectedThemes)
                                {
                                    if (!selectedThemeId.Contains(theme.ID_Theme))
                                    {
                                        string selectedDiscipName = theme.Discipline.Name_Discipline;
                                        GroupDisciplineValidator validator =
                                            new GroupDisciplineValidator(
                                                "C:/Users/Валерий/source/repos/WpfApp7/WpfApp7/Rules/GroupsDisciplinesRules.json");
                                        bool isValid =
                                            validator.IsGroupDisciplineValid(selectedGroupName, selectedDiscipName);

                                        if (isValid)
                                        {
                                            validTheme.Add(theme);
                                        }
                                    }
                                }

                                if (validTheme.Any())
                                {
                                    Random rnd = new Random();
                                    int index = rnd.Next(validTheme.Count());
                                    var selectedTheme = validTheme[index];

                                    var newList = new List
                                    {
                                        Student_ID = student.ID_Student,
                                        ID_Theme = selectedTheme.ID_Theme,
                                        ID_Disciline = selectedTheme.Theme_Discipline
                                    };

                                    context.List.Add(newList);

                                    selectedTheme.ID_Selected_Theme = selectedTheme.ID_Theme;

                                    groupCount[selectedGroupName]--;
                                    themeCount[selectedTheme.ID_Theme]++;

                                    selectedThemeId.Add(selectedTheme.ID_Theme);

                                    if (groupCount.Values.All(count => count == 0))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    groupCount[selectedGroupName]--;
                                    MessageBox.Show($"Для группы {selectedGroupName} не осталось свободных тем");
                                }
                            }
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show("Все темы распределены");
                }
            }
        }

        private void UpdateStudentList()
        {
            if (Ngroup.SelectedIndex == 0)
            {
                DataUnStudent.ItemsSource = GetAviableStudents();
            }
            else
            {
                var group = Ngroup.SelectedItem as Groups;
                if (group != null)
                {
                    ICollectionView view = CollectionViewSource.GetDefaultView(DataUnStudent.ItemsSource);
                    view.Filter = s => ((Students)s).ID_St_Group == group.ID_Groups;
                    DataUnStudent.ItemsSource = view;
                }
            }
        }

        private List<Students> GetAviableStudents()
        {
            var currentList = delivery_of_term_papers_by_studentsEntities.GetContext().List.ToList();
            var excludedIds = currentList.Where(p => p.Student_ID.HasValue).Select(p => p.Student_ID.Value).ToList();

            return delivery_of_term_papers_by_studentsEntities.GetContext().Students
                .Where(x => !excludedIds.Contains(x.ID_Student)).ToList();
        }

        private void UpdateUnSelectedThemeList()
        {
            if (NDiscipline.SelectedIndex == 0)
            {
                DataUnSelectedTheme.ItemsSource = GetAviableUnselectedThemes();
            }
            else
            {
                var discipline = NDiscipline.SelectedItem as Discipline;
                if (discipline != null)
                {
                    ICollectionView view = CollectionViewSource.GetDefaultView(DataUnSelectedTheme.ItemsSource);
                    view.Filter = s => ((Theme)s).Theme_Discipline == discipline.ID_Disciplines;
                    DataUnSelectedTheme.ItemsSource = view;
                }
            }
        }

        private List<Theme> GetAviableUnselectedThemes()
        {
            return delivery_of_term_papers_by_studentsEntities.GetContext().Theme
                .Where(x => x.ID_Selected_Theme == null).ToList();
        }


        private void UpdateTheme()
        {
            UpdateStudentList();
            UpdateUnSelectedThemeList();
        }

        private void Ngroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTheme();
        }

        private void NDiscipline_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTheme();
        }
    }
}