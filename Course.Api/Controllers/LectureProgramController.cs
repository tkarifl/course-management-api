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
    public class LectureProgramController : ControllerBase
    {
        private readonly ILectureProgramService _lectureProgramService;

        public LectureProgramController(ILectureProgramService lectureProgramService)
        {
            _lectureProgramService = lectureProgramService;
        }

        // Get lecture programs
        [HttpGet]
        public IActionResult GetLecturePrograms()
        {
            return Ok(_lectureProgramService.Get());
        }

        // Get specified lecture program
        [HttpGet("{id}")]
        public IActionResult GetLectureProgram(long id)
        {
            var lectureProgram = _lectureProgramService.Get(id);
            if (lectureProgram == null)
            {
                return NotFound();
            }

            return Ok(lectureProgram);
        }

        // Update specified lecture program
        [HttpPut("{id}")]
        public IActionResult PutLectureProgram(LectureProgramDto lectureProgram)
        {
            if (_lectureProgramService.Update(lectureProgram))
            {
                return NoContent();
            }

            return NotFound();
        }

        // Create new lecture program
        [HttpPost]
        public IActionResult PostLectureProgram(LectureProgramDto lectureProgram)
        {
            if (_lectureProgramService.Add(lectureProgram))
            {
                return CreatedAtAction("GetLectureProgram", new { id = lectureProgram.LectureProgramId }, lectureProgram);
            }
            return Ok("Lecture program with the same id already exists.");

        }

        // Delete specified lecture program
        [HttpDelete("{id}")]
        public IActionResult DeleteLectureProgram(long id)
        {
            if (_lectureProgramService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("The Lecture program cannot be deleted because it was not found");
        }
    }
}
