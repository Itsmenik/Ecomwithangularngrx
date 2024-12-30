using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.Model;

namespace server.Controller
{


    [Route("api/[controller]")]
    [ApiController]  


  
public class EcommerceController : ControllerBase
{

     [HttpGet("get-products")]
    public IActionResult GetProducts()
    {
        var products = new List<EcommerceModel>
        {
            new EcommerceModel
            {
                ProductId = 1,
                ProductSku = "SKU001",
                ProductName = "Product A",
                ProductPrice = 25.50m,
                ProductShortName = "ProdA",
                ProductDescription = "Description for Product A",
                CreatedDate = DateTime.UtcNow,
                DeliveryTimeSpan = "2-4 days",
                CategoryId = 101,
                ProductImageUrl = "https://example.com/productA.jpg",
                CategoryName = "Category A"
            },
            new EcommerceModel
            {
                ProductId = 2,
                ProductSku = "SKU002",
                ProductName = "Product B",
                ProductPrice = 50.00m,
                ProductShortName = "ProdB",
                ProductDescription = "Description for Product B",
                CreatedDate = DateTime.UtcNow,
                DeliveryTimeSpan = "3-5 days",
                CategoryId = 102,
                ProductImageUrl = "https://example.com/productB.jpg",
                CategoryName = "Category B"
            },
            new EcommerceModel
            {
                ProductId = 3,
                ProductSku = "SKU003",
                ProductName = "Product C",
                ProductPrice = 75.00m,
                ProductShortName = "ProdC",
                ProductDescription = "Description for Product C",
                CreatedDate = DateTime.UtcNow,
                DeliveryTimeSpan = "1-2 days",
                CategoryId = 103,
                ProductImageUrl = "https://example.com/productC.jpg",
                CategoryName = "Category C"
            }
        };

        return Ok(products); 
    }
}

}
