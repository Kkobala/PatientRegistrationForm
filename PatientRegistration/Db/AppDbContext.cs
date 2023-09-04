using Microsoft.EntityFrameworkCore;
using PatientRegistration.Db.Entities;

namespace PatientRegistration.Db
{
    public class AppDbContext : DbContext
    {
        public DbSet<PatientEntity> Patients { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
