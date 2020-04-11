using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Entities
{
    interface IRepositorySchedule<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        TEntity FindById(int id);
        void Remove(TEntity item);
        void Update(TEntity item);
        IEnumerable<TEntity> GetAll(TEntity item);
    }
}
