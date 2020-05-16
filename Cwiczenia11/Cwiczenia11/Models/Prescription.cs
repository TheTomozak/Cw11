﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Cwiczenia11.Models
{
    public class Prescription
    {
        public int IdPrescription { get; set; }

        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        
        public int IdPatient { get; set; }
     
        public int IdDoctor { get; set; }

        public Doctor Doctor { get; set; }

        public Patient Patient { get; set;}

    }
}
