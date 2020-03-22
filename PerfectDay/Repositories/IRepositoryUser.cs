using Microsoft.EntityFrameworkCore;
using PerfectDay.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Repositories
{
    public class IRepositoryUser<TEntity> : IRepository<TEntity> where TEntity : class
    {
        ApplicationContex _context;
        DbSet<TEntity> _dbSet;
        public IRepositoryUser(ApplicationContex context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public void Delete(TEntity item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();

        }

        public TEntity FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
