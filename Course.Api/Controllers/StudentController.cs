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
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // Get students
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_studentService.Get());
        }

        // Get specified student
        [HttpGet("{id}")]
        public IActionResult GetStudent(long id)
        {
            var student = _studentService.Get(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // Update specified student
        [HttpPut("{id}")]
        public IActionResult PutStudent(StudentDto student)
        {
            if (_studentService.Update(student))
            {
                return NoContent();
            }

            return NotFound();
        }

        // Create new student
        [HttpPost]
        public IActionResult PostStudent(StudentDto student)
        {
            if (_studentService.Add(student))
            {
                return CreatedAtAction("GetStudent", new { id = student.StudentId }, student);
            }
            return Ok("Student with the same id already exists.");

        }

        // Delete specified student
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(long id)
        {
            if (_studentService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("The student cannot be deleted because it was not found");
        }

    }
}
