using Microsoft.EntityFrameworkCore;
using System;

namespace lab_8_ColinKorsmo.Models
{
    public class PatientDbContext : DbContext
    {
        public PatientDbContext(DbContextOptions<PatientDbContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                    Id = 1,
                    FirstName = "Samantha",
                    LastName = "Carter",
                    AdmitDate = DateTime.Parse("10/01/2024"),
                    SymptomDescription = "Severe migraines, Erratic behavior"
                },
                new Patient
                {
                    Id = 2,
                    FirstName = "Jack",
                    LastName = "O'Neill",
                    AdmitDate = DateTime.Parse("10/02/2024"),
                    SymptomDescription = "Hallucinations, Memory loss"
                },
                new Patient
                {
                    Id = 3,
                    FirstName = "Daniel",
                    LastName = "Jackson",
                    AdmitDate = DateTime.Parse("10/04/2024"),
                    SymptomDescription = "Seizures, Extreme mood swings"
                },
                new Patient
                {
                    Id = 4,
                    FirstName = "George",
                    LastName = "Hammond",
                    AdmitDate = DateTime.Parse("10/14/2024"),
                    SymptomDescription = "Loss of motor control, Speech difficulties"
                },
                new Patient
                {
                    Id = 5,
                    FirstName = "Janet",
                    LastName = "Fraiser",
                    AdmitDate = DateTime.Parse("10/20/2024"),
                    SymptomDescription = "Persistent dizziness, Glows in the dark"
                });
        }
    }
}
