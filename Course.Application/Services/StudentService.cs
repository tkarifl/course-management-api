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
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _studentRepo;
        private readonly IMapper _mapper;
        public StudentService(IStudentRepo studentRepo, IMapper mapper)
        {
            _studentRepo = studentRepo;
            _mapper = mapper;
        }
        public bool Add(StudentDto student)
        {
            return _studentRepo.Add(_mapper.Map<Domain.Entities.Student>(student));

        }

        public bool Delete(long id)
        {
            return _studentRepo.Delete(id);
        }

        public List<StudentDto> Get()
        {
            return _mapper.Map<List<StudentDto>>(_studentRepo.Get());
        }

        public StudentDto Get(long id)
        {
            return _mapper.Map<StudentDto>(_studentRepo.Get(id));
        }

        public bool Update(StudentDto student)
        {
            return _studentRepo.Update(_mapper.Map<Domain.Entities.Student>(student));
        }
    }
}
