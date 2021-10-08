using AutoMapper;
using Course.Application.Dto;
using Course.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Application.Services
{
    public class LectureProgramService : ILectureProgramService
    {
        private readonly ILectureProgramRepo _lectureProgramRepo;
        private readonly IMapper _mapper;
        public LectureProgramService(ILectureProgramRepo lectureProgramRepo, IMapper mapper)
        {
            _lectureProgramRepo = lectureProgramRepo;
            _mapper = mapper;
        }
        public bool Add(LectureProgramDto lectureProgram)
        {
            return _lectureProgramRepo.Add(_mapper.Map<Domain.Entities.LectureProgram>(lectureProgram));

        }

        public bool Delete(long id)
        {
            return _lectureProgramRepo.Delete(id);
        }

        public List<LectureProgramDto> Get()
        {
            return _mapper.Map<List<LectureProgramDto>>(_lectureProgramRepo.Get());
        }

        public LectureProgramDto Get(long id)
        {
            return _mapper.Map<LectureProgramDto>(_lectureProgramRepo.Get(id));
        }

        public bool Update(LectureProgramDto lectureProgram)
        {
            return _lectureProgramRepo.Update(_mapper.Map<Domain.Entities.LectureProgram>(lectureProgram));
        }
    }
}
