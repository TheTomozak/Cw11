using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.DTOs;
using Cwiczenia11.DTOs.Requests;
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

        public HelperRequest UpdateDoctor(UpdateDoctorRequest request)
        {
            var helper = new HelperRequest();

            var countDoctor = _context.Doctors.Count(doc =>
                doc.LastName == request.LastName && doc.FirstName == request.FirstName);

            if (countDoctor == 0)
            {
                helper.Number = 0;
                return helper;
            }

            var doctor = new Doctor
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
            };

            _context.Attach(doctor);
            _context.Entry(doctor).Property("FirstName").IsModified = true;
            _context.Entry(doctor).Property("LastName").IsModified = true;
            _context.Entry(doctor).Property("Email").IsModified = true;

            _context.SaveChangesAsync();

            helper.Number = 1;

            return helper;
        }

        public string AddNewDoctor(AddNewDoctorRequest request)
        {
            
            var doctor = new Doctor
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
               
            };

            _context.Attach(doctor);
            _context.Add(doctor);
            _context.SaveChangesAsync();

            return "Doctor added";
        }

        public HelperRequest DeleteDoctor(DeleteDoctorRequest request)
        {
            var helper = new HelperRequest();

            var countDoctor = _context.Doctors.Count(doc =>
                doc.LastName == request.LastName && doc.FirstName == request.FirstName);

            if (countDoctor == 0)
            {
                helper.Number = 0;
                return helper;
            }

            var selectDoctorId = _context.Doctors.Where(doc =>
                doc.LastName == request.LastName && doc.FirstName == request.FirstName).Select(x => x.IdDoctor).ToArray();


            var doctor = new Doctor
            {
                IdDoctor = selectDoctorId[0]
            };

            _context.Attach(doctor);
            _context.Remove(doctor);
            _context.SaveChangesAsync();

            helper.Number = 1;
            return helper;
        }
    }
}