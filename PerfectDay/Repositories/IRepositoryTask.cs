using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Repositories
{
<<<<<<< HEAD:PerfectDay/Repositories/IRepositoryUser.cs
    public interface IRepositoryUser<TEntity>
=======
    public interface IRepositoryTask<TEntity>
>>>>>>> sprint_4:PerfectDay/Repositories/IRepositoryTask.cs
    {
        void Create(TEntity item);
        void Update(TEntity item);
        TEntity FindById(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity item);
        IEnumerable<TEntity> GetAll();
    }
}