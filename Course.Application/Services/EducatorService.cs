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
    public class EducatorService : IEducatorService
    {
        private readonly IEducatorRepo _educatorRepo;
        private readonly IMapper _mapper;
        public EducatorService(IEducatorRepo educatorRepo, IMapper mapper)
        {
            _educatorRepo = educatorRepo;
            _mapper = mapper;
        }
        public bool Add(EducatorDto educator)
        {
            return _educatorRepo.Add(_mapper.Map<Domain.Entities.Educator>(educator));

        }

        public bool Delete(long id)
        {
            return _educatorRepo.Delete(id);
        }

        public List<EducatorDto> Get()
        {
            return _mapper.Map<List<EducatorDto>>(_educatorRepo.Get());
        }

        public EducatorDto Get(long id)
        {
            return _mapper.Map<EducatorDto>(_educatorRepo.Get(id));
        }

        public bool Update(EducatorDto educator)
        {
            return _educatorRepo.Update(_mapper.Map<Domain.Entities.Educator>(educator));
        }
    }
}
