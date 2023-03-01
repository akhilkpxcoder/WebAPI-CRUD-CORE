using Microsoft.EntityFrameworkCore;

namespace WebAPI_CRUD_CORE.Models
{
    public class StudentContext :DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) :base(options)
        {

        }

        public DbSet<Student> Students { get;set; }
    }
}
