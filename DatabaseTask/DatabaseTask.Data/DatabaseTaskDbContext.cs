using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;



namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }


        public DbSet<Employee> Employee { get; set; }

        public DbSet<Hint> Hint { get; set; }
        public DbSet<Job_Title> JobTitle { get; set; }
        public DbSet<Work_time> WorkTime { get; set; }
        public DbSet<Borrowed_Item> BorrowedItems { get; set;}
        public DbSet<Employees_Child>Employees_Children { get; set; }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Request> Requests {  get; set; } 
        public DbSet<Access_Level> AccessLevels { get; set; }
        public DbSet<Health_Check> HealthChecks { get; set; }
        public DbSet<Sick_Leave> SickLeave { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Branch_Office> Branches { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}


