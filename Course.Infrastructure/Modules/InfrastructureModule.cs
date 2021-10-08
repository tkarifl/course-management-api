using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Infrastructure.Repositories;
using Course.Domain.Repositories;

namespace Course.Infrastructure.Modules
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureModule(this IServiceCollection services)
        {
            services.AddScoped<ICourseRepo, CourseRepo>();
            services.AddScoped<IStudentRepo, StudentRepo>();
            services.AddScoped<ILectureRepo, LectureRepo>();
            services.AddScoped<ILectureProgramRepo, LectureProgramRepo>();
            services.AddScoped<IEducatorRepo, EducatorRepo>();
            return services;
        }
    }
}
