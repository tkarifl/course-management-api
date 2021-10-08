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
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        // Get courses
        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(_courseService.Get());
        }

        // Get specified course
        [HttpGet("{id}")]
        public IActionResult GetCourse(long id)
        {
            var course = _courseService.Get(id);
            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }

        // Update specified course
        [HttpPut("{id}")]
        public IActionResult PutCourse(CourseDto course)
        {
            if (_courseService.Update(course))
            {
                return NoContent();
            }

            return NotFound();
        }

        // Create new course
        [HttpPost]
        public IActionResult PostCourse(CourseDto course)
        {
            if (_courseService.Add(course))
            {
                return CreatedAtAction("GetCourse", new { id = course.CourseId }, course);
            }
            return Ok("Course with the same id already exists.");

        }

        // Delete specified course
        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(long id)
        {
            if (_courseService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("The course cannot be deleted because it was not found");
        }

    }
}
