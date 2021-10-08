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
    public class CourseService : ICourseService
    {

        private readonly ICourseRepo _courseRepo;
        private readonly IMapper _mapper;
        public CourseService(ICourseRepo courseRepo, IMapper mapper)
        {
            _courseRepo = courseRepo;
            _mapper = mapper;
        }
        public bool Add(CourseDto course)
        {
            return _courseRepo.Add(_mapper.Map<Domain.Entities.Course>(course));

        }

        public bool Delete(long id)
        {
            return _courseRepo.Delete(id);
        }

        public List<CourseDto> Get()
        {
            return _mapper.Map<List<CourseDto>>(_courseRepo.Get());
        }

        public CourseDto Get(long id)
        {
            return _mapper.Map<CourseDto>(_courseRepo.Get(id));
        }

        public bool Update(CourseDto course)
        {
            return _courseRepo.Update(_mapper.Map<Domain.Entities.Course>(course));
        }
    }
}
