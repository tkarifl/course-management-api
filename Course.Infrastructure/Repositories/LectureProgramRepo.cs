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
    public class LectureProgramRepo : Repo<LectureProgram>, ILectureProgramRepo
    {
        public LectureProgramRepo(CourseDbContext dbContext) : base(dbContext)
        {

        }
    }
}
