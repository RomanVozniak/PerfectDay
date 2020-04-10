using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Repositories
{
    public interface IRepositoryTask<TEntity>
    {
        void Create(TEntity item);
        void Update(TEntity item);
        TEntity FindById(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity item);
    }
}