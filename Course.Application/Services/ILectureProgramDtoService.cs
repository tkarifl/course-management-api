using Course.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace Course.Application.Services
{
    public interface ILectureProgramService
    {
        List<LectureProgramDto> Get();
        LectureProgramDto? Get(long id);
        bool Update(LectureProgramDto lectureProgram);
        bool Add(LectureProgramDto lectureProgram);
        bool Delete(long id);
    }
}
