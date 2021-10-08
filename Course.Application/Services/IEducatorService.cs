using Course.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace Course.Application.Services
{
    public interface IEducatorService
    {
        List<EducatorDto> Get();
        EducatorDto? Get(long id);
        bool Update(EducatorDto educator);
        bool Add(EducatorDto educator);
        bool Delete(long id);
    }
}
