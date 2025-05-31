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

        public ProductByOrderController(BusinessContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductByOrder>>> GetProductByOrder() =>
            await _context.ProductByOrders.ToListAsync();
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductByOrder>> GetProductByOrder(int id)
        {
            var productByOrder = await _context.ProductByOrders.FindAsync(id);

            if (productByOrder == null)
                return NotFound();

            return Ok(productByOrder);
        }

        [HttpPost]
        public async Task<ActionResult<ProductByOrder>> PostProductByOrder(ProductByOrderDto productByOrder)
        {
            var _productByOrder = new ProductByOrder()
            {
                ProductID = productByOrder.ProductID,
                OrderID = productByOrder.OrderID,
                Quantity = productByOrder.Quantity,
                ProductByOrderActive = productByOrder.ProductByOrderActive,
            };

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
            
            _productByOrder.ProductID = productByOrder.ProductID;
            _productByOrder.OrderID = productByOrder.OrderID;
            _productByOrder.Quantity = productByOrder.Quantity;
            _productByOrder.ProductByOrderActive = productByOrder.ProductByOrderActive;

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