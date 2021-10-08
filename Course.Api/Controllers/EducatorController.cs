using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Course.Application.Services;
using Course.Application.Dto;

namespace Course_Management_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducatorController : ControllerBase
    {
        private readonly IEducatorService _educatorService;

        public EducatorController(IEducatorService educatorService)
        {
            _educatorService = educatorService;
        }

        // Get educators
        [HttpGet]
        public IActionResult GetEducators()
        {
            return Ok(_educatorService.Get());
        }

        // Get specified educator
        [HttpGet("{id}")]
        public IActionResult GetEducator(long id)
        {
            var educator = _educatorService.Get(id);
            if (educator == null)
            {
                return NotFound();
            }

            return Ok(educator);
        }

        // Update specified educator
        [HttpPut("{id}")]
        public IActionResult PutEducator(EducatorDto educator)
        {
            if (_educatorService.Update(educator))
            {
                return NoContent();
            }

            return NotFound();
        }

        // Create new educator
        [HttpPost]
        public IActionResult PostEducator(EducatorDto educator)
        {
            if (_educatorService.Add(educator))
            {
                return CreatedAtAction("GetEducator", new { id = educator.EducatorId }, educator);
            }
            return Ok("Educator with the same id already exists.");

        }

        // Delete specified educator
        [HttpDelete("{id}")]
        public IActionResult DeleteEducator(long id)
        {
            if (_educatorService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("The educator cannot be deleted because it was not found");
        }
    }
}
