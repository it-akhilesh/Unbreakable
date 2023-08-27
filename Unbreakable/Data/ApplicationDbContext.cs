using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Unbreakable.Models;

namespace Unbreakable.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)

        {
            
        }
        public DbSet <Employee> employees { get; set; }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Address = "Matiyari", Name = "Akhileh", PhoneNumber = 6392803867},
                new Employee { Id = 2, Address = "janakpuri", Name = "Rakesh", PhoneNumber = 6392803868 },
                new Employee { Id = 3, Address = "Banaras", Name = "Gulshan", PhoneNumber = 6392803864 }
                );
        }
    }
}
