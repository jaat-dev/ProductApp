using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Repositories.Base;
using ProductApp.Infrastructure.Persistence;

namespace ProductApp.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var obj = await _db.Set<T>().FindAsync(id);
            return obj!;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
