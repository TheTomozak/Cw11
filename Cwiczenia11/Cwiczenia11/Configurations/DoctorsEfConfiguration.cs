using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia11.Configurations
{
    public class DoctorsEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(key => key.IdDoctor);    //ustawnienie IdDoctora jako klucz

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired(); //ustawienie imienia jako wymagane plus max dlugosc = 100

            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();

            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
        }
    }
}
