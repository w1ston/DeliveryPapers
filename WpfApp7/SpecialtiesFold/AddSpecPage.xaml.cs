using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace WpfApp7.SpecialtiesFold
{
    public partial class AddSpecPage
    {
        private Specialties currentSpec = new Specialties();

        public AddSpecPage(Specialties selectedSpec)
        {
            InitializeComponent();
            LimitLength();

            if (selectedSpec != null)
            {
                currentSpec = selectedSpec;
            }

            DataContext = currentSpec;
        }

        private void LimitLength()
        {
            Special.MaxLength = 30;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            Groups spec = delivery_of_term_papers_by_studentsEntities.GetContext().Groups.FirstOrDefault(p => p.Name_Group == Special.Text);

            if (currentSpec.ID_Specialties == 0)
            {
                if (spec != null)
                {
                    errors.AppendLine("Такая группа уже есть");
                }
            }

            if (string.IsNullOrWhiteSpace(currentSpec.Name_Specialties))
                errors.AppendLine("Введите название специальности");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (currentSpec.ID_Specialties == 0)
                delivery_of_term_papers_by_studentsEntities.GetContext().Specialties.Add(currentSpec);

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

        private void Special_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
