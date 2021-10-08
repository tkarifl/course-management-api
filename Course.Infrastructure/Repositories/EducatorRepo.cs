using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Domain.Entities;
using Course.Domain.Repositories;
using Course.Infrastructure.Context;

namespace Course.Infrastructure.Repositories
{
    public class EducatorRepo : Repo<Educator>, IEducatorRepo
    {
        public EducatorRepo(CourseDbContext dbContext) : base(dbContext)
        {

        }
    }
}
