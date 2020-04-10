using Microsoft.EntityFrameworkCore;
using PerfectDay.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Repositories
{
    public class RepositorySchedule<TEntity> : IRepository<TEntity> where TEntity : class
    {
        ApplicationContex IRepository;
        DbSet<TEntity> _dbSet;
        public RepositorySchedule(ApplicationContex context)
        {
            _dbSet = IRepository.Set<TEntity>();
        }
        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            IRepository.SaveChanges();
        }

        public void Delete(TEntity item)
        {
            _dbSet.Remove(item);
            IRepository.SaveChanges();

        }

        public TEntity FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity item)
        {
            IRepository.Entry(item).State = EntityState.Modified;
            IRepository.SaveChanges();
        }
    }
}