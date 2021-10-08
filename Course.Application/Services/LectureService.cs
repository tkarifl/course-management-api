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
    public class LectureService : ILectureService
    {
        private readonly ILectureRepo _lectureRepo;
        private readonly IMapper _mapper;
        public LectureService(ILectureRepo lectureRepo, IMapper mapper)
        {
            _lectureRepo = lectureRepo;
            _mapper = mapper;
        }
        public bool Add(LectureDto lecture)
        {
            return _lectureRepo.Add(_mapper.Map<Domain.Entities.Lecture>(lecture));

        }

        public bool Delete(long id)
        {
            return _lectureRepo.Delete(id);
        }

        public List<LectureDto> Get()
        {
            return _mapper.Map<List<LectureDto>>(_lectureRepo.Get());
        }

        public LectureDto Get(long id)
        {
            return _mapper.Map<LectureDto>(_lectureRepo.Get(id));
        }

        public bool Update(LectureDto lecture)
        {
            return _lectureRepo.Update(_mapper.Map<Domain.Entities.Lecture>(lecture));
        }
    }
}
