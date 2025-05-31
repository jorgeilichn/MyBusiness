using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBusiness_DB.Models
{
    [Table("Order", Schema = "store")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        
        [MaxLength(50)]
        public string OnCreated { get; set; } = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        
        [MaxLength(50)]
        public string CustomerName { get; set; }
        
        public bool OrderStatus { get; set; }

        public ICollection<Product> Products { get; } = [];
        public ICollection<ProductByOrder> ProductByOrders { get; } = [];
    }
}