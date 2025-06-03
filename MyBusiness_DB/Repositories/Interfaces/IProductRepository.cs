using MyBusiness_DB.Models;

namespace MyBusiness_DB.Repositories;

public interface IProductRepository : IRepository<Product>
{
    Task<Product> Update(Product product);
    
}