using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.DTOs;
using Cwiczenia11.DTOs.Requests;
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

        [HttpPost]
        public IActionResult UpdateDoctor(UpdateDoctorRequest updateDoctorRequest)
        {
            HelperRequest helper = _context.UpdateDoctor(updateDoctorRequest);

            switch (helper.Number)
            {
                case 0:
                    return BadRequest("Doctor with this Name and Lastname not exist");
                default:
                    return Ok("Doctor modify");
            }
        }

        [HttpPut]
        public IActionResult AddDoctor(AddNewDoctorRequest request)
        {
            return Ok(_context.AddNewDoctor(request));
        }

        [HttpDelete]
        public IActionResult RemoveDoctor(DeleteDoctorRequest request)
        {
            HelperRequest helperRequest = _context.DeleteDoctor(request);

            switch (helperRequest.Number)
            {
                case 0:
                    return BadRequest("Doctor with this Name and Lastname not exist");
                default:
                    return Ok("Doctor remove");
            }
        }
    }
}