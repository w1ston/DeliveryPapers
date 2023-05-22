using System;

namespace Lesson19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var context = new MyDbContext())
            {
                var themee = new Theme()
                {
                    Name_Theme = "Ведомость сдачи практических работ студентами",
                    Id_Theme = 1,
                    Theme_Selected_Id = 1
                };
                context.Theme.Add(themee);
                context.SaveChanges();

                Console.WriteLine($"id: {themee.Id_Theme}, name: {themee.Name_Theme}, id_selected: {themee.Theme_Selected_Id}");
                Console.ReadLine();
            }    
        }
    }
}
