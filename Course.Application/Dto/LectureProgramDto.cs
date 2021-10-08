using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Course.Application.Dto
{
    public class LectureProgramDto
    {
        public long LectureProgramId { get; set; }
        public long LectureId { get; set; }
        public long EducatorId { get; set; }
    }
}
