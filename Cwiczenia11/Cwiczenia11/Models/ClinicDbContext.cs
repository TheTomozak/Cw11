using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Configurations;
using Cwiczenia11.SampleData;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia11.Models
{
    public class ClinicDbContext : DbContext
    {
        /*
         add-migration nameOfMigration
         update-database

         */

        public ClinicDbContext()
        {
        }

        public ClinicDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Prescription_Medicament> PrescriptionMedicaments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DoctorsEfConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentEfConfiguration());
            modelBuilder.ApplyConfiguration(new PatientsEfConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionsEfConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionsMedicamentsEfConfiguration());

            modelBuilder.ApplyConfiguration(new AddSampleDataForDoctor());
            modelBuilder.ApplyConfiguration(new AddSampleDataForMedicament());
            modelBuilder.ApplyConfiguration(new AddSampleDataForPatient());
            modelBuilder.ApplyConfiguration(new AddSampleDataForPrescription());
            modelBuilder.ApplyConfiguration(new AddSampleDataForPrescriptionMedicament());
        }

        
    }
}