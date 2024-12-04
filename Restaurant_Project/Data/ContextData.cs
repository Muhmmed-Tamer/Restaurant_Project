using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant_Project.Models;

namespace Restaurant_Project.Data
{
    public class ContextData  :IdentityDbContext<ApplicationUser>
    {
        public ContextData(DbContextOptions<ContextData> Options):base(Options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //
            builder.Entity<Table>().HasIndex(t => t.TableNumber).IsUnique();

            base.OnModelCreating(builder);
        }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Chef> Chefs { get; set; } 
    }
}
