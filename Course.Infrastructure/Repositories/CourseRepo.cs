using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Domain.Repositories;
using Course.Infrastructure.Context;

namespace Course.Infrastructure.Repositories
{
    public class CourseRepo : Repo<Domain.Entities.Course>, ICourseRepo
    {
        public CourseRepo(CourseDbContext dbContext) : base(dbContext)
        {

        }
    }
}
