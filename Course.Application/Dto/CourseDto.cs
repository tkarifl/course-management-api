using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Course.Application.Dto
{
    public class CourseDto
    {
        public long CourseId { get; set; }
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Course Name should be between 5 and 30 characters")]
        public string CourseName { get; set; }
    }
}
