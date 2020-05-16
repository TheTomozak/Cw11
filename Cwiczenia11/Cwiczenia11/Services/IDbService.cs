using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;

namespace Cwiczenia11.Services
{
    public interface IDbService
    {
        public IEnumerable<Doctor> GetDoctors();
    }
}
