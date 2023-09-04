using Microsoft.EntityFrameworkCore;
using PatientRegistration.Db;
using PatientRegistration.Repositories;

namespace PatientRegistration
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=LocalHost;Database=Patient_db;Trusted_Connection=true;MultipleActiveResultSets=True;Encrypt=False;")
                .Options;

            using (var dbContext = new AppDbContext(options))
            {
                var repository = new PatientRepository(dbContext);

                Application.Run(new PatientForm(dbContext, repository));
            }
        }
    }
}