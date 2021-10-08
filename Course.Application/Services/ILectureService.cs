using Course.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace Course.Application.Services
{
    public interface ILectureService
    {
        List<LectureDto> Get();
        LectureDto? Get(long id);
        bool Update(LectureDto lecture);
        bool Add(LectureDto lecture);
        bool Delete(long id);
    }
}
