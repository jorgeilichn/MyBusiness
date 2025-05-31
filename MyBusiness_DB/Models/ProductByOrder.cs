using System.ComponentModel.DataAnnotations.Schema;

namespace MyBusiness_DB.Models
{
    [Table("ProductByOrder", Schema = "store")]
    public class ProductByOrder
    {
        public int ProductID { get; set; }
        
        public int OrderID { get; set; }
        
        public int Quantity { get; set; }
        
        public bool ProductByOrderActive { get; set; }
    }
}