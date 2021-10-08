using Course.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace Course.Application.Services
{
    public interface IStudentService
    {
        List<StudentDto> Get();
        StudentDto? Get(long id);
        bool Update(StudentDto student);
        bool Add(StudentDto student);
        bool Delete(long id);
    }
}
