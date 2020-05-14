using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia11.Models
{
    public class ClinicDbContext : DbContext
    {

        public ClinicDbContext() {}

        public ClinicDbContext(DbContextOptions options) : base(options)
        {

        }



        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DoctorsEfConfiguration());
        }
    }
}
