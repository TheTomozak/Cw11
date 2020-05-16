using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Cwiczenia11.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia11.Controllers
{
    [Route("api/clinic")]
    [ApiController]
    public class ClinicsController : ControllerBase
    {

        private readonly IDbService _context;


        public ClinicsController(IDbService context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctor()
        {
            return Ok(_context.GetDoctors());
        }

        
    }
}