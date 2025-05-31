using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBusiness_DB.Models
{
    [Table("UnitOfMeasurement", Schema = "store")]
    public class UnitOfMeasurement
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int UnitOfMeasurementId { get; set; }
    
        [MaxLength(50)]
        public string UnitOfMeasurementName { get; set; }
    
        [MaxLength(10)]
        public string UnitOfMeasurementInitials { get; set; }
        
        public bool UnitOfMeasurementActive { get; set; }
        
        public ICollection<Product> Products { get; set; }
    }
}