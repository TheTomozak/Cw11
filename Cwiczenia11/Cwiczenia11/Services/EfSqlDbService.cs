using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;

namespace Cwiczenia11.Services
{
    public class EfSqlDbService : IDbService
    {

        private readonly ClinicDbContext _context;


        public EfSqlDbService(ClinicDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }
    }
}
