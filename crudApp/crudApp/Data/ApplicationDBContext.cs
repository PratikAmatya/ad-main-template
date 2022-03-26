using Microsoft.EntityFrameworkCore;
using crudApp.Models;

namespace crudApp.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
