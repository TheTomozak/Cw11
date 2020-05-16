using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia11.Configurations
{
    public class PrescriptionsMedicamentsEfConfiguration : IEntityTypeConfiguration<Prescription_Medicament>
    {
        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            builder.HasKey(key => new {key.IdMedicament, key.IdPrescription});
            builder.HasOne(t => t.Medicament).WithMany().HasForeignKey(t => t.IdMedicament);

            builder.HasOne(t => t.Prescription).WithMany().HasForeignKey(t => t.IdPrescription);

            builder.Property(prop => prop.Dose).IsRequired();
            builder.Property(prop => prop.Details).HasMaxLength(100).IsRequired();
        }
    }
}