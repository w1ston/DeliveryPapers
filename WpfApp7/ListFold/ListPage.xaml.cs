using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.InkML;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Win32;
using WpfApp7.ReadneesFold;
using WpfApp7.Rules;
using WpfApp7.SemFold;
using WpfApp7.StudentInSemFold;
using Application = Microsoft.Office.Interop.Word.Application;
using Document = Microsoft.Office.Interop.Word.Document;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Table = DocumentFormat.OpenXml.InkML.Table;

namespace WpfApp7.ListFold
{
    public partial class ListPage
    {
        private int _count;
        const Visibility Hidden = Visibility.Hidden;
        const Visibility Visible = Visibility.Visible;

        private List<GroupDisciplineRule> rules;

        public ListPage(int count)
        {
            InitializeComponent();
            RefreshList();

            _count = count;

            Readness.Visibility = count == 1 ? Hidden : Visible;
            DelList.Visibility = count == 1 ? Hidden : Visible;
            AddList.Visibility = count == 1 ? Hidden : Visible;
            SemBtn.Visibility = count == 1 ? Hidden : Visible;
            StudInSem.Visibility = count == 1 ? Hidden : Visible;
            SearchList.Visibility = count == 1 ? Hidden : Visible;
            DocX.Visibility = count == 1 ? Hidden : Visible;


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

            ComboDiscip.ItemsSource = discip;
            ComboDiscip.SelectedIndex = 0;
        }

        public void RefreshList()
        {
            delivery_of_term_papers_by_studentsEntities.GetContext().ChangeTracker.Entries().ToList()
                .ForEach(p => p.Reload());
            DataGridList.ItemsSource = delivery_of_term_papers_by_studentsEntities.GetContext().List.ToList();
        }

        private void DelList_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridList.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Уведомление", MessageBoxButton.YesNo,
                        MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var currentList = DataGridList.SelectedItem as List;
                    if (currentList != null)
                    {
                        var currentTheme = currentList.Theme;
                        delivery_of_term_papers_by_studentsEntities.GetContext().List.Remove(currentList);
                        currentTheme.ID_Selected_Theme = null;
                    }

                    delivery_of_term_papers_by_studentsEntities.GetContext().SaveChanges();

                    DataGridList.ItemsSource = delivery_of_term_papers_by_studentsEntities.GetContext().List.ToList();
                }
            }
            else
            {
                MessageBox.Show("Выберите запись которую хотите удалить");
            }
        }

        private void AddList_Click(object sender, RoutedEventArgs e)
        {
            var currentList = DataGridList.SelectedItem as List;
            if (DataGridList.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для добавление / редактирования данных");
            }
            else
                NavigationService?.Navigate(new AddListPage(currentList));
        }

        private void Readness_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridList.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента");
            }
            else
            {
                var selectedStud = DataGridList.SelectedItem as List;
                ReadWindow wind = new ReadWindow(selectedStud, this);
                Pages.Visibility = Visibility.Hidden;
                wind.ShowDialog();
            }
        }

        private void UpdateList()
        {
            int? selectedGroupId = null;
            int? selectedDiscipId = null;

            if (ComboGroup.SelectedIndex > 0)
            {
                selectedGroupId = (ComboGroup.SelectedItem as Groups)?.ID_Groups;
            }

            if (ComboDiscip.SelectedIndex > 0)
            {
                selectedDiscipId = (ComboDiscip.SelectedItem as Discipline)?.ID_Disciplines;
            }

            var dbContext = delivery_of_term_papers_by_studentsEntities.GetContext();

            var query = dbContext.List
                .Include(l => l.Theme)
                .Include(l => l.Theme.Discipline)
                .Include(l => l.Students)
                .Include(l => l.Students.Groups);

            if (selectedGroupId.HasValue)
                query = query.Where(l => l.Students.Groups.ID_Groups == selectedGroupId.Value);

            if (selectedDiscipId.HasValue)
                query = query.Where(l => l.Theme.Discipline.ID_Disciplines == selectedDiscipId.Value);

            var list = query.ToList();
            DataGridList.ItemsSource = list;
        }

        private void ComboGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();

            if (ComboGroup.SelectedIndex > 0 && ComboDiscip.SelectedIndex > 0)
            {
                GroupDisciplineValidator validator =
                    new GroupDisciplineValidator(
                        "C:/Users/Валерий/source/repos/WpfApp7/WpfApp7/Rules/GroupsDisciplinesRules.json");

                string selectedGroupName = (ComboGroup.SelectedItem as Groups)?.Name_Group;
                string selectedDiscipName = (ComboDiscip.SelectedItem as Discipline)?.Name_Discipline;

                bool isValid = validator.IsGroupDisciplineValid(selectedGroupName, selectedDiscipName);

                if (!isValid)
                {
                    MessageBox.Show("Группа не содержит такой дисциплины");
                }
            }

            var selectedGroup = (ComboGroup.SelectedItem as Groups)?.Name_Group;
            var filteredDisciplines = FiltereDisciplinesGroup(selectedGroup);
            ComboDiscip.ItemsSource = filteredDisciplines;
            ComboDiscip.SelectedIndex = 0;
        }

        private List<Discipline> FiltereDisciplinesGroup(string groupName)
        {
            GroupDisciplineValidator validator =
                new GroupDisciplineValidator(
                    "C:/Users/Валерий/source/repos/WpfApp7/WpfApp7/Rules/GroupsDisciplinesRules.json");
            List<Discipline> disciplines = delivery_of_term_papers_by_studentsEntities.GetContext().Discipline.ToList();

            var filteredDisciplines = disciplines
                .Where(d => validator.IsGroupDisciplineValid(groupName, d.Name_Discipline)).ToList();

            filteredDisciplines.Insert(0, new Discipline
            {
                Name_Discipline = "Все дисциплины"
            });

            return filteredDisciplines;
        }


        private void DocXBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ComboGroup.SelectedIndex == 0)
            {
                MessageBox.Show("Пожалуйста веберите группу, для которой нужна ведомость");
            }
            else
            {
                if (MessageBox.Show("Учтите, что вы можете выбрать для какой именно группы создавать документ.",
                        "Уведомление", MessageBoxButton.OKCancel,
                        MessageBoxImage.Question) == MessageBoxResult.OK)
                {
                    CreateDocument();
                }
            }
        }

        private void CreateDocument()
        {
            string fileName = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Документ Word (*.docx)|*.docx";
            
            if (saveFileDialog.ShowDialog() == true)
            {
                fileName = saveFileDialog.FileName;
            }
            else
            {
                return;
            }
            
            
            string directiryPath = Path.GetDirectoryName(fileName);
            
            Application wordApp = new Application();
            Document wordDoc = wordApp.Documents.Add();
            
            wordDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            
            DataGrid dg = DataGridList;
            
            if (wordDoc.Paragraphs.Count > 0)
            {
                Word.Paragraph paragraph = wordDoc.Paragraphs[1];
                paragraph.Range.InsertBefore("Ведомость для: " + ((Groups)ComboGroup.SelectedItem).Name_Group + " " +
                                             ((Discipline)ComboDiscip.SelectedItem).Name_Discipline);
                paragraph.Range.InsertParagraphAfter();
            }
            
            int rowCount = dg.Items.Count;
            int colCount = dg.Columns.Count;
            Word.Table table = wordDoc.Tables.Add(wordDoc.Paragraphs.Last.Range, rowCount + 1, colCount);
            
            table.Borders.Enable = 1;
            table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            
            for (int i = 0; i < colCount; i++)
            {
                table.Cell(1, i + 1).Range.Text = dg.Columns[i].Header.ToString();
            }
            
            for (int row = 0; row < rowCount; row++)
            {
                if (dg.Items[row] is List list)
                {
                    table.Cell(row + 2, 1).Range.Text = list.Students.St_Name;
                    table.Cell(row + 2, 2).Range.Text = list.Students.St_Surname;
                    table.Cell(row + 2, 3).Range.Text = list.Students.St_Patronymic;
                    table.Cell(row + 2, 4).Range.Text = list.Theme.Name_Theme;
                    table.Cell(row + 2, 5).Range.Text = list.Students.Groups.Name_Group;
                    table.Cell(row + 2, 6).Range.Text = list.Theme.Discipline.Name_Discipline;
            
            
                    if (list.Half_Year != null)
                        table.Cell(row + 2, 7).Range.Text = list.Semester.ID_Semester.ToString();
                    else
                    {
                        MessageBox.Show("Пожалуйста, заполните для всех студентов семместер");
                        return;
                    }
            
                    table.Cell(row + 2, 8).Range.Text = list.Readiness_Degree.ToString();
                    table.Cell(row + 2, 9).Range.Text = list.Grade.ToString();
            
                    if (list.Work_submition_date != null)
                        table.Cell(row + 2, 10).Range.Text = list.Work_submition_date == new DateTime(0001, 01, 01)
                            ? ""
                            : list.Work_submition_date.Value.ToString("dd.MM.yyyy");
                }
            }
            wordDoc.SaveAs2(fileName);
            wordDoc.Close();
            
            wordApp.Quit();

            MessageBox.Show("Данные сохранены в документ Word");
        }

        private void ComboDiscip_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }

        private void SearchList_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SearchListPage());
        }

        private void StudInSemBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new StudentInSemPage());
        }

        private void SemBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SemPage());
        }

        private void Page_IsVisiblePage(object sender, DependencyPropertyChangedEventArgs e)
        {
            RefreshList();
        }
    }
}