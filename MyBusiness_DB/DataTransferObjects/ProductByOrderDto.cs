namespace MyBusiness_DB.DataTransferObjects
{
    public record ProductByOrderDto
    {
        public int ProductID { get; set; }
        
        public int OrderID { get; set; }
        
        public int Quantity { get; set; }
        
        public bool ProductByOrderActive { get; set; }
    }
}