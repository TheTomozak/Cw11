using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia11.Configurations
{
    public class PatientsEfConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(key => key.IdPatient);

            builder.Property(prop => prop.FirstName).HasMaxLength(100).IsRequired();

            builder.Property(prop => prop.LastName).HasMaxLength(100).IsRequired();

            builder.Property(prop => prop.Birthdate).IsRequired();
        }
    }
}
