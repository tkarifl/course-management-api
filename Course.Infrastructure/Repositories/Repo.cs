using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Course.Domain.Repositories;
using Course.Infrastructure.Context;

namespace Course.Infrastructure.Repositories
{
    public class Repo<TEntity> : IRepo<TEntity> where TEntity : class, new()
    {

        private readonly CourseDbContext _context;
        DbSet<TEntity> _dbSet;

        public Repo(CourseDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public bool Add(TEntity entity)
        {
            if (!_dbSet.Any(e=>e==entity))
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(long id)
        {
            var entity = _dbSet.Find(id);
            if (entity == null)
            {
                return false;
            }

            _dbSet.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<TEntity> Get()
        {
            return _dbSet.ToList();
        }

        public TEntity? Get(long id)
        {
            return _dbSet.Find(id);
        }

        public bool Update(TEntity entity)
        {
            if (!_dbSet.Any(e => e == entity))
            {
                return false;
            }
            _context.Entry(entity).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                    throw;
            }

            return true;
        }
    }
}
