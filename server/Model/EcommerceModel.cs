namespace server.Model
{
    public class EcommerceModel
    { 
        public int ProductId { get; set; }
        public string ProductSku { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductShortName { get; set; }
        public string ProductDescription { get; set; }
        public DateTime CreatedDate { get; set; } // Parsed as ISO date
        public string DeliveryTimeSpan { get; set; }
        public int CategoryId { get; set; }
        public string ProductImageUrl { get; set; }
        public string CategoryName { get; set; }  


    } 
}
