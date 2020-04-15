using Microsoft.EntityFrameworkCore;
using PerfectDay.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PerfectDay.Repositories
{
    public class RepositoryGoal<TEntity> : BaseRepository, IRepositoryGoal<TEntity> where TEntity : BaseEntity
    {
        DbSet<TEntity> _dbSet;
        public RepositoryGoal(ApplicationContex context) : base(context)
        {
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
            return _dbSet.FirstOrDefault(e => e.Id == id);
        }

        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }
    }
}
