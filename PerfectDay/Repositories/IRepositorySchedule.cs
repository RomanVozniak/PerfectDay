using Microsoft.EntityFrameworkCore;
using PerfectDay.Entities;
using System;
using System.Collections.Generic;

namespace PerfectDay.Repositories
{
    public interface IRepositorySchedule<TEntity> 
    {
        void Create(TEntity item);
        TEntity FindById(int id);
        void Remove(TEntity item);
        void Update(TEntity item);
        IEnumerable<TEntity> GetAll();
    }
}
