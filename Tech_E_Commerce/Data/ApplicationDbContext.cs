using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Tech_E_Commerce
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> categories { get; set}
    }
}