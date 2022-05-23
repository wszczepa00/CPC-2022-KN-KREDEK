using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
