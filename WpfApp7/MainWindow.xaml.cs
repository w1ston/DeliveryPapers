using System.Windows;
using WpfApp7.ChoiceThemeFold;
using WpfApp7.DisciplineFold;
using WpfApp7.ListFold;
using WpfApp7.LogIn;
using WpfApp7.Student;
using WpfApp7.ThemeFold;

namespace WpfApp7
{
    public partial class MainWindow
    {
        delivery_of_term_papers_by_studentsEntities context = new delivery_of_term_papers_by_studentsEntities();
        private int count;

        public MainWindow(int count)
        {
            InitializeComponent();
            this.count = count;

            if (count == 1)
            {
                StudList.IsEnabled = false;
                DiscipList.IsEnabled = false;
                regTeach.Visibility = Visibility.Hidden;
            }
            else
            {
                StudList.IsEnabled = true;
                DiscipList.IsEnabled = true;

            }
        }

        private void StudList_Click(object sender, RoutedEventArgs e)
        {
            PagesFrame.Content = new StudentsPage();
        }

        private void DiscipList_Click(object sender, RoutedEventArgs e)
        {
            PagesFrame.Content = new DisciplinePage();
        }

        private void ThemList_Click(object sender, RoutedEventArgs e)
        {
            PagesFrame.Content = new ThemePage(count);
        }

        private void ChoiceTheme_Click(object sender, RoutedEventArgs e)
        {
            PagesFrame.Content = new ChoiceThemePage(count);
        }

        private void ListSt_Click(object sender, RoutedEventArgs e)
        {
            PagesFrame.Content = new ListPage(count);
        }


        private void MiniMized_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Closing_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RegTeach_OnClick(object sender, RoutedEventArgs e)
        {
            RegWindow wind1 = new RegWindow();
            wind1.Show();
            Close();
        }
    }
}