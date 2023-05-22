using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using WpfApp7.ListFold;

namespace WpfApp7.ReadneesFold
{
    public partial class ReadWindow
    {
        private ListPage _parrentPage;

        private List _currentList;

        public ReadWindow(List selectedStud, ListPage parrentPage)
        {
            InitializeComponent();

            First.MaxLength = 2;
            Second.MaxLength = 2;

            _currentList = selectedStud;

            DataContext = _currentList;

            this._parrentPage = parrentPage;
            Closing += SelReadWindow_Closing;
        }

        private void First_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Second_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SelReadWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _parrentPage.RefreshList();
            _parrentPage.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int firstValue = int.TryParse(First.Text, out int first) ? first : 0;
            int secondValue = int.TryParse(Second.Text, out int second) ? second : 0;

            int resulte = firstValue + secondValue;

            if (resulte >= 0 && resulte <= 100)
            {
                Result.Text = resulte.ToString();

                try
                {

                    using (var context = new delivery_of_term_papers_by_studentsEntities())
                    {
                        var list = context.List.Find(_currentList.ID_List);

                        if (list != null)
                        {
                            list.Readiness_Degree = resulte;
                            context.SaveChanges();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка сохранения");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите корректные числа");
            }
        }

        private void BtnBack(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
