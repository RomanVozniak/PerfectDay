using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PerfectDay.Entities;

namespace PerfectDay.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly ApplicationContex _context;

        public BaseRepository(ApplicationContex context)
        {
            _context = context;
        }
    }
}
