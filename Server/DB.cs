using Microsoft.EntityFrameworkCore;
using Teeest2.Shared;

namespace Teeest2.Server
{
    public class DB:DbContext
    {
        public DbSet<Osoba> Osobe { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>().HasKey(o => o.Id);
        }
        public DB(DbContextOptions<DB> dbco) : base(dbco)  
        {
        }
    }
}
