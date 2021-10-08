using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Course.Application.Dto
{
    public class LectureDto
    {
        public long LectureId { get; set; }
        public long CourseId { get; set; }
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Lecture Code should be 5 characters long")]
        public string LectureCode { get; set; }
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Lecture Name should be between 5 and 30 characters")]
        public string LectureName { get; set; }
    }
}
