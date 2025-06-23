namespace MyBusiness_DB.DataTransferObjects;

public class ProductUpdateDto
{
    public int ProductID { get; set; }
    
    public string ProductName { get; set; }
        
    public int BrandID { get; set; }
        
    public string? ProductDescription { get; set; }
        
    public double ProductPrice { get; set; }
    
    public string? ProductImage { get; set; }
        
    public int UnitOfMeasurementID { get; set; }
        
    public double InStockQuantity { get; set; }
        
    public bool ProductActive { get; set; }
}