using MyBusiness_DB.Models;

namespace MyBusiness_DB.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    private BusinessContext _context;

    public ProductRepository(BusinessContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Product> Update(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
        return product;
    }
    
}