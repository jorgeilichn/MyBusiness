using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBusiness_DB;
using MyBusiness_DB.DataTransferObjects;
using MyBusiness_DB.Models;

namespace MyBusiness_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private BusinessContext _context;
        private IMapper _mapper;    

        public ProductController(BusinessContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct() =>
            _mapper.Map<ActionResult<IEnumerable<Product>>>(await _context.Products.OrderBy(p => p.ProductID).ToListAsync()) ;

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
                return NotFound();

            return Ok(_mapper.Map<Product>(product));
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(ProductDto product)
        {
            var _product = _mapper.Map<Product>(product);  
            
            _context.Products.Add(_product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = _product.ProductID }, _product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, ProductDto product)
        {
            var _product = await _context.Products.FindAsync(id);

            if (_product == null)
                return NotFound();
            
            _product = _mapper.Map<Product>(product);
            
            _context.Products.Update(_product);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Conflict();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var _product = await _context.Products.FindAsync(id);
            
            if (_product == null)
                return NotFound();
            
            _context.Products.Remove(_product);
            await _context.SaveChangesAsync();
            
            return _product;
        }
    }
}