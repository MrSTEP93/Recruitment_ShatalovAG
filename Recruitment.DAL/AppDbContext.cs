using Microsoft.EntityFrameworkCore;
using Recruitment.DAL.Models.Company;
using Recruitment.DAL.Models.People;
using Recruitment.DAL.Models.Recruitment;

namespace Recruitment.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Grade> Roles { get; set; }

        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<VacancyStatus> VacancyStatuses { get; set; }
        public DbSet<VacancyHistory> VanancyHistories { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        
        public DbSet<CandidateHistory> CandidateHistories { get; set; }
        public DbSet<SelectionStage> SelectionStages { get; set; }


        public AppDbContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = Recruitment; Trusted_Connection = True");
            //string connectionString = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "connString.txt"));
            //optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
