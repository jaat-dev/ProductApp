using ProductApp.Domain.Entities;
using ProductApp.Infrastructure.Persistence;
using ProductApp.Infrastructure.Repositories.Base;

namespace ProductApp.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
