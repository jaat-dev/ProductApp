using ProductApp.Domain.Entities;
using ProductApp.Domain.Repositories;
using ProductApp.Infrastructure.Repositories.Base;

namespace ProductApp.Infrastructure.Repositories
{
    public class CategoryRepository : Repository <Repository>, ICategoryRepository
    {  
    }
}
