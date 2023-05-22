using System.Collections.Generic;

namespace Lesson19
{
    public class Selected_Theme
    {
        public int Id_Selected_Theme { get; set; }
        public string Name_Theme { get; set; }
        public int Grade { get; set; }
        public int Readiness_Degree { get; set; }
        public int Number_Students { get; set; }

        public virtual Theme Theme { get; set; }
    }
}
