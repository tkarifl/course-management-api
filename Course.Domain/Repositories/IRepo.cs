using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Domain.Repositories
{
    public interface IRepo<TEntity> where TEntity : class, new()
    {
        List<TEntity> Get();
        TEntity? Get(long id);
        bool Update(TEntity entity);
        bool Add(TEntity entity);
        bool Delete(long id);
    }
}
