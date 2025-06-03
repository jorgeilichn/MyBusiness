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
    public class ProductByOrderController : ControllerBase
    {
        private BusinessContext _context;
        private IMapper _mapper;

        public ProductByOrderController(BusinessContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductByOrder>>> GetProductByOrder() =>
            _mapper.Map<ActionResult<IEnumerable<ProductByOrder>>>(await _context.ProductByOrders.ToListAsync());
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductByOrder>> GetProductByOrder(int id)
        {
            var productByOrder = await _context.ProductByOrders.FindAsync(id);

            if (productByOrder == null)
                return NotFound();

            return Ok(_mapper.Map<ProductByOrder>(productByOrder));
        }

        [HttpPost]
        public async Task<ActionResult<ProductByOrder>> PostProductByOrder(ProductByOrderDto productByOrder)
        {
            var _productByOrder = _mapper.Map<ProductByOrder>(productByOrder);

            _context.ProductByOrders.Add(_productByOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductByOrder", productByOrder);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductByOrder(int id, ProductByOrderDto productByOrder)
        {
            var _productByOrder = await _context.ProductByOrders.FindAsync(id);

            if (_productByOrder == null)
                return NotFound();
            
            _productByOrder = _mapper.Map<ProductByOrder>(productByOrder);

            _context.ProductByOrders.Update(_productByOrder);
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
        public async Task<ActionResult<ProductByOrder>> DeleteProductByOrder(int id)
        {
            var _productByOrder = await _context.ProductByOrders.FindAsync(id);
            
            if (_productByOrder == null)
                return NotFound();
            
            _context.ProductByOrders.Remove(_productByOrder);
            await _context.SaveChangesAsync();
            
            return _productByOrder;
        }
    }
}