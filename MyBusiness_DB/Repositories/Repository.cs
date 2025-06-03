using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace MyBusiness_DB.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private BusinessContext _context;
        internal DbSet<T> dbSet;

        public Repository(BusinessContext context)
        {
            _context = context;
            this.dbSet = context.Set<T>();
        }
        
        public async Task Add(T entity)
        {
            await dbSet.AddAsync(entity);
            await SaveChanges();
        }

        public  async Task<List<T>> GetAll(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = dbSet;
            
            if (filter != null)
                query = query.Where(filter);
            
            return await query.ToListAsync();
        }

        public async Task<T> Get(Expression<Func<T, bool>> filter = null, bool tracked = true)
        {
            IQueryable<T> query = dbSet;
            
            if (!tracked)
                query = query.AsNoTracking();
            
            if (filter != null)
                query = query.Where(filter);
            
            return await query.FirstOrDefaultAsync();
        }

        public async Task Remove(T entity)
        {
            this.dbSet.Remove(entity);
            await SaveChanges();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    
    }
}