using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia11.Configurations
{
    public class PrescriptionsEfConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(key => key.IdPrescription);

            builder.Property(date => date.Date).IsRequired();

            builder.Property(date => date.DueDate).IsRequired();

            builder.HasOne( t => t.Patient).WithMany().HasForeignKey(t => t.IdPatient);

            builder.HasOne( t => t.Doctor).WithMany().HasForeignKey(t => t.IdDoctor);

        }
    }
}
