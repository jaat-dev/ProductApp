using ProductApp.Domain.Entities;
using ProductApp.Domain.Repositories;
using ProductApp.Infrastructure.Repositories.Base;

namespace ProductApp.Infrastructure.Repositories
{
    internal class ProductRepository : Repository<Product>, IProductRepository
    {
    }
}
