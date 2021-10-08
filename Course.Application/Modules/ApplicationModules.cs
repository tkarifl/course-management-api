using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Course.Application.Mapping;
using Course.Infrastructure.Modules;
using Course.Application.Services;
using Microsoft.Extensions.DependencyInjection;


namespace Course.Application.Modules
{
    public static class ApplicationModules
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services.AddInfrastructureModule();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ILectureProgramService, LectureProgramService>();
            services.AddScoped<ILectureService, LectureService>();
            services.AddScoped<IEducatorService, EducatorService>();
            return services;
        }
    }
}
