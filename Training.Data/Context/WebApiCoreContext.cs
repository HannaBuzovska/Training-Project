using System;
using Microsoft.EntityFrameworkCore;
using Training.Data.Models;

namespace Training.Data.Context
{
    public class WebApiCoreContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public WebApiCoreContext(DbContextOptions<WebApiCoreContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = "1", Name = "Александр", ProfessionalActivity = "Терапевт"});
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = "2", Name = "Петр", ProfessionalActivity = "Педиатр"});
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = "3", Name = "Вячеслав", ProfessionalActivity = "Хирург"});
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = "4", Name = "Иван", ProfessionalActivity = "Стоматолог"});
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = "5", Name = "Владислав", ProfessionalActivity = "Офтальмолог"});
        }
    }
}
