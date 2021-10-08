using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Course.Application.Dto
{
    public class StudentDto
    {
        public long StudentId { get; set; }
        public long CourseId { get; set; }
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name should be between 2 and 20 characters")]
        public string Name { get; set; }
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Surname should be between 2 and 20 characters")]
        public string Surname { get; set; }
        [RegularExpression("(M|W)", ErrorMessage = "Only M or W is allowed")]
        public string Gender { get; set; }
    }
}
