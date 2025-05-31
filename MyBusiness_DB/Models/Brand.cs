using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBusiness_DB.Models
{
    [Table("Brand", Schema = "store")]
    public class Brand
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }
    
        [MaxLength(50)]
        public string BrandName { get; set; }
        
        public bool BrandActive { get; set; }
        
        public ICollection<Product>? Products { get; set; }
    }
}