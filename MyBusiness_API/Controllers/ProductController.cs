using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBusiness_DB;
using MyBusiness_DB.DataTransferObjects;
using MyBusiness_DB.Models;
using MyBusiness_DB.Repositories;

namespace MyBusiness_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _context;
        private IMapper _mapper;
        protected APIResponse _response;

        public ProductController(IProductRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _response = new ();
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetProduct()
        {
            try
            {
                IEnumerable<Product> products = await _context.GetAll();

                _response.Result = _mapper.Map<IEnumerable<Product>>(products);
                _response.statusCode = HttpStatusCode.OK;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.Message };
            }
            
            return _response;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<APIResponse>> GetProduct(int id)
        {
            try
            {
                var product = await _context.Get(p => p.ProductID == id);

                if (product == null)
                {
                    _response.IsSuccess = false;
                    _response.statusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
            
                _response.Result = _mapper.Map<Product>(product);
                _response.statusCode = HttpStatusCode.OK;

                return Ok(_response);
            }
            catch (Exception ex)
            {
               _response.IsSuccess = false;
               _response.ErrorMessages = new List<string>() { ex.Message };
            }

            return _response;
        }

        [HttpPost]
        public async Task<ActionResult<APIResponse>> PostProduct(ProductDto product)
        {
            try
            {
                var _product = _mapper.Map<Product>(product);  
            
                await _context.Add(_product);
                _response.Result = _product;
                _response.statusCode = HttpStatusCode.Created;

                return CreatedAtAction("GetProduct", new { id = _product.ProductID }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.Message };
            }
            
            return _response;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, ProductDto product)
        {
            try
            {
                var _product = await _context.Get(p => p.ProductID == id);

                if (_product == null)
                {
                    _response.statusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
            
                _product = _mapper.Map<Product>(product);
            
                _context.Update(_product);
                _response.statusCode = HttpStatusCode.NoContent;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.Message };
            }
            
            return BadRequest(_response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.IsSuccess = false;
                    _response.statusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
            
                var _product = await _context.Get(p => p.ProductID == id);

                if (_product == null)
                {
                    _response.IsSuccess = false;
                    _response.statusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
            
                _context.Remove(_product);
                _response.statusCode = HttpStatusCode.NoContent;
            
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.Message };
            }
            
            return BadRequest(_response);
            
        }
    }
}