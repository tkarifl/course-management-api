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
    public class StudentRepo:Repo<Student>,IStudentRepo
    {
        public StudentRepo(CourseDbContext dbContext) : base(dbContext)
        {

        }
    }
}
