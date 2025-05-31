using System.ComponentModel.DataAnnotations;
using MyBusiness_DB.Models;

namespace MyBusiness_DB.DataTransferObjects
{
    public record OrderDto
    {
        public string CustomerName { get; set; }
        
        public bool OrderStatus { get; set; }
    }
}