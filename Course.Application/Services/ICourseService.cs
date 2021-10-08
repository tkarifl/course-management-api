using Course.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace Course.Application.Services
{
    public interface ICourseService
    {
        List<CourseDto> Get();
        CourseDto? Get(long id);
        bool Update(CourseDto course);
        bool Add(CourseDto course);
        bool Delete(long id);
    }
}
