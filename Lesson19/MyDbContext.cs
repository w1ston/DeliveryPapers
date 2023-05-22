using System;
using System.Data.Entity;

namespace Lesson19
{
    internal class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnectionString")
        {
        }

        public DbSet<Theme> Theme { get; set; }
        public DbSet<Selected_Theme> SelectedThemes { get; set; }
    }
}
