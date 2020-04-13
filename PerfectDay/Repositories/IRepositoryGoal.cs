using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Repositories
{
    public interface IRepositoryGoal<TEntity>
    {
        void Create(TEntity item);
        void Update(TEntity item);
        TEntity FindById(int id);
        void Delete(TEntity item);
        IEnumerable<TEntity> GetAll(TEntity item);
    }
}
