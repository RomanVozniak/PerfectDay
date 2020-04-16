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
