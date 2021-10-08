using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Course.Application.Dto;
using Course.Domain.Entities;

namespace Course.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Domain.Entities.Course, CourseDto>().ReverseMap();
            CreateMap<Lecture, LectureDto>().ReverseMap();
            CreateMap<Educator, EducatorDto>().ReverseMap();
            CreateMap<LectureProgram, LectureProgramDto>().ReverseMap();
        }
    }
}
