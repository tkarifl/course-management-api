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
    public class LectureController : ControllerBase
    {
        private readonly ILectureService _lectureService;

        public LectureController(ILectureService lectureService)
        {
            _lectureService = lectureService;
        }

        // Get lectures
        [HttpGet]
        public IActionResult GetLectures()
        {
            return Ok(_lectureService.Get());
        }

        // Get specified lecture
        [HttpGet("{id}")]
        public IActionResult GetLecture(long id)
        {
            var lecture = _lectureService.Get(id);
            if (lecture == null)
            {
                return NotFound();
            }

            return Ok(lecture);
        }

        // Update specified lecture
        [HttpPut("{id}")]
        public IActionResult PutLecture(LectureDto lecture)
        {
            if (_lectureService.Update(lecture))
            {
                return NoContent();
            }

            return NotFound();
        }

        // Create new lecture
        [HttpPost]
        public IActionResult PostLecture(LectureDto lecture)
        {
            if (_lectureService.Add(lecture))
            {
                return CreatedAtAction("GetLecture", new { id = lecture.LectureId }, lecture);
            }
            return Ok("Lecture with the same id already exists.");

        }

        // Delete specified lecture
        [HttpDelete("{id}")]
        public IActionResult DeleteLecture(long id)
        {
            if (_lectureService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("The lecture cannot be deleted because it was not found");
        }
    }
}
