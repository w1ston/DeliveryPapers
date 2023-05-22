using System.Windows;

namespace WpfApp7.LogIn
{
    public partial class ChoiceUsWindow
    {
        public ChoiceUsWindow()
        {
            InitializeComponent();
        }

        private void TeachBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow wind = new AuthorizationWindow();
            wind.Show();
            Close();
        }

        private void StudBtn_Click(object sender, RoutedEventArgs e)
        {
            ChoiceStud wind = new ChoiceStud();
            wind.Show();
            Close();
        }

    }
}
