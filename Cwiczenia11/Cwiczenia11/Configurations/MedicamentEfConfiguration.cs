using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia11.Configurations
{
    public class MedicamentEfConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(key => key.IdMedicament);    

            builder.Property(e => e.Name).HasMaxLength(100).IsRequired(); 

            builder.Property(e => e.Description).HasMaxLength(100).IsRequired();

            builder.Property(e => e.Type).HasMaxLength(100).IsRequired();
        }
    }
}
