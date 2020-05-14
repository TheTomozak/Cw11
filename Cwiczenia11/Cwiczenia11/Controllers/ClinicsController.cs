using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia11.Controllers
{
    [Route("api/clinic")]
    [ApiController]
    public class ClinicsController : Controller
    {

        private readonly ClinicDbContext _context;


        public ClinicsController(ClinicDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctor()
        {
            return Ok(_context.Doctors.ToList());
        }
    }
}