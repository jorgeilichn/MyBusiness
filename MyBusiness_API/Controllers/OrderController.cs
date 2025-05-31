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
    public class OrderController : ControllerBase
    {
        private BusinessContext _context;
        private IMapper _mapper;    

        public OrderController(BusinessContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder() =>
            _mapper.Map<ActionResult<IEnumerable<Order>>>(await _context.Orders.OrderBy(o => o.OrderId).ToListAsync()) ;
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
                return NotFound();

            return Ok(_mapper.Map<Order>(order));
        }

        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(OrderDto order)
        {
            var _order = _mapper.Map<Order>(order);

            _context.Orders.Add(_order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = _order.OrderId }, _order);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, OrderDto order)
        {
            var _order = await _context.Orders.FindAsync(id);

            if (_order == null)
                return NotFound();
            
            _order = _mapper.Map<Order>(order);
            
            _context.Orders.Update(_order); 
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
        public async Task<ActionResult<Order>> DeleteOrder(int id)
        {
            var _order = await _context.Orders.FindAsync(id);
            
            if (_order == null)
                return NotFound();
            
            _context.Orders.Remove(_order);
            await _context.SaveChangesAsync();
            
            return _order;
        }
    }
}