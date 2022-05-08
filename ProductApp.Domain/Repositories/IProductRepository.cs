using ProductApp.Domain.Entities;
using ProductApp.Domain.Repositories.Base;

namespace ProductApp.Domain.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
