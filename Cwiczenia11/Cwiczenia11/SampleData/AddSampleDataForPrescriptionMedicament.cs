using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia11.SampleData
{
    public class AddSampleDataForPrescriptionMedicament : IEntityTypeConfiguration<Prescription_Medicament>
    {
        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            
            var dictPrescription_Medicament = new List<Prescription_Medicament>();

            dictPrescription_Medicament.Add(new Prescription_Medicament{Details = "Lykac", Dose = 3, IdMedicament = 1, IdPrescription = 1});
            dictPrescription_Medicament.Add(new Prescription_Medicament{Details = "Wciagac", Dose = 5, IdMedicament = 2, IdPrescription = 2});
            dictPrescription_Medicament.Add(new Prescription_Medicament{Details = "Lykac", Dose = 10, IdMedicament = 3, IdPrescription = 3});

            builder.HasData(dictPrescription_Medicament);

        }
    }
}
