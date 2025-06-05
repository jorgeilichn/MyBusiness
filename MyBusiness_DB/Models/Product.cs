using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBusiness_DB.Models
{
    [Table("Product", Schema = "store")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        
        [MaxLength(50)]
        public string ProductName { get; set; }
        
        public int BrandID { get; set; }
        
        public string? ProductDescription { get; set; }
        
        public double ProductPrice { get; set; }
        
        [MaxLength(128)]
        public string? ProductImage { get; set; }
        
        public int UnitOfMeasurementID { get; set; }
        
        public double InStockQuantity { get; set; }
        
        public bool ProductActive { get; set; }

        public ICollection<Order> Orders { get; } = [];
        public ICollection<ProductByOrder> ProductByOrders { get; } = [];
    }
}