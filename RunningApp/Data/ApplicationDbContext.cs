using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RunningApp.Models;

namespace RunningApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser> //Identity & EFR should have same version
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
