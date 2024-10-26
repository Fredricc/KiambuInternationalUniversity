using KiambuInternationalUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace KiambuInternationalUniversity.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
