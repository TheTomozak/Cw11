using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia11.SampleData
{
    public class AddSampleDataForPatient : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {

            var dictPatient = new List<Patient>();
          
            dictPatient.Add(new Patient{Birthdate = Convert.ToDateTime("1990-03-05"), FirstName = "Jon", LastName = "Kowal", IdPatient = 1});;
            dictPatient.Add(new Patient{Birthdate = Convert.ToDateTime("1994-03-05"), FirstName = "Alicja", LastName = "Czarow", IdPatient = 2 });;
            dictPatient.Add(new Patient{Birthdate = Convert.ToDateTime("1980-01-01"), FirstName = "Joker", LastName = "Batman", IdPatient = 3 });;

            builder.HasData(dictPatient);

        }
    }
}
