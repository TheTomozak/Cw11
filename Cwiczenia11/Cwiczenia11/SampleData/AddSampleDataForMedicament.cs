using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia11.SampleData
{
    public class AddSampleDataForMedicament : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            var dictMedicaments = new List<Medicament>();

            dictMedicaments.Add(new Medicament{Description = "Na bol glowy", IdMedicament = 1, Name = "Apap", Type = "tabletki"});
            dictMedicaments.Add(new Medicament{Description = "Na humor", IdMedicament = 2, Name = "Kokaina", Type = "proszek"});
            dictMedicaments.Add(new Medicament{Description = "Na odporosc", IdMedicament = 3, Name = "WitaminaC", Type = "tabletki"});

            builder.HasData(dictMedicaments);

        }
    }
}
