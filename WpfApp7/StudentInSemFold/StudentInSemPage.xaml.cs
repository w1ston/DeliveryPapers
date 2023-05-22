using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp7.ListFold;

namespace WpfApp7.StudentInSemFold
{
    public partial class StudentInSemPage
    {
        public StudentInSemPage()
        {
            InitializeComponent();

            var sem = delivery_of_term_papers_by_studentsEntities.GetContext().Semester.ToList();
            ComboSem.ItemsSource = sem;
            ComboSem.SelectedIndex = 0;

            var group = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.ToList();
            var discip = delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.ToList();
            
            group.Insert(0, new Groups
            {
                Name_Group = "Все группы"
            });

            ComboGroup.ItemsSource = group;
            ComboGroup.SelectedIndex = 0;

            discip.Insert(0, new Discipline
            {
                Name_Discipline = "Все дисциплины"
            });

            ComboDiscipline.ItemsSource = discip;
            ComboDiscipline.SelectedIndex = 0;

        }

        private void ComboSem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDate();
        }

        private void ComboGroup_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }

        private void ComboDiscipline_OnSelectionChanged_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }

        private void UpdateDate()
        {
            int selectedSemester = ComboSem.SelectedIndex + 5;
            var dbContext = delivery_of_term_papers_by_studentsEntities.GetContext();
            dbContext.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());

            var unreadyStudents = dbContext.List.Where(p => p.Readiness_Degree < 50 && p.Half_Year == selectedSemester);
            var readyStudents = dbContext.List.Where(p => p.Readiness_Degree >= 50 && p.Half_Year == selectedSemester);

            DataUnStudent.ItemsSource = unreadyStudents.ToList();
            DataInStudent.ItemsSource = readyStudents.ToList();
        }

        private void UpdateList()
        {
            var dbContext = delivery_of_term_papers_by_studentsEntities.GetContext();

            int selectedSemester = ComboSem.SelectedIndex + 5;
            

            var selectedGroup = ComboGroup.SelectedItem as Groups;
            var selectedDiscip = ComboDiscipline.SelectedItem as Discipline;

            var unreadyStudents = dbContext.List.Where(p => p.Readiness_Degree < 50 && p.Half_Year == selectedSemester);
            var readyStudents = dbContext.List.Where(p => p.Readiness_Degree >= 50 && p.Half_Year == selectedSemester);

            if (ComboGroup.SelectedIndex > 0)
            {
                if (selectedGroup != null)
                {
                    var groupUnStudents =
                        unreadyStudents.Where(x => x.Students.Groups.Name_Group == selectedGroup.Name_Group);
                    var groupReadyStudents =
                        readyStudents.Where(x => x.Students.Groups.Name_Group == selectedGroup.Name_Group);

                    unreadyStudents = groupUnStudents;
                    readyStudents = groupReadyStudents;
                }
            }

            if (ComboDiscipline.SelectedIndex > 0)
            {
                if (selectedDiscip != null)
                {
                    var discipUnStudents = unreadyStudents.Where(x =>
                        x.Theme.Discipline.Name_Discipline == selectedDiscip.Name_Discipline);
                    var discipReadyStudents = readyStudents.Where(x =>
                        x.Theme.Discipline.Name_Discipline == selectedDiscip.Name_Discipline);

                    unreadyStudents = discipUnStudents;
                    readyStudents = discipReadyStudents;
                }
            }

            DataUnStudent.ItemsSource = unreadyStudents.ToList();
            DataInStudent.ItemsSource = readyStudents.ToList();
        }

        private void SearchTheme_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SearchListPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

    }
}
