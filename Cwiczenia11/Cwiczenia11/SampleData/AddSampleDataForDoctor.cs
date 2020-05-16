using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia11.SampleData
{
    public class AddSampleDataForDoctor : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            var dictDoctor = new List<Doctor>();
            dictDoctor.Add(new Doctor{ Email = "cos1@wp.pl", FirstName = "Jan", LastName = "Kowalski", IdDoctor = 1});
            dictDoctor.Add(new Doctor{ Email = "mail@wp.pl", FirstName = "Andzrej", LastName = "Andzejewski", IdDoctor = 2});
            dictDoctor.Add(new Doctor{ Email = "tralalal@wp.pl", FirstName = "Przemek", LastName = "Przemkowski", IdDoctor = 3});

            builder.HasData(dictDoctor);


        }
    }
}
