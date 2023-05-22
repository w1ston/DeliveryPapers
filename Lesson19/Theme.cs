using System.Collections.Generic;

namespace Lesson19
{
    public class Theme
    {
        public int Id_Theme { get; set; }
        public string Name_Theme { get; set; }
        public int Theme_Selected_Id { get; set; }

        public virtual ICollection<Selected_Theme> Selected_Themes { get; set; }
    }
}
