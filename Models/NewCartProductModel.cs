using System.Text.Json.Serialization;

namespace PlaywrightEcommerceFramework.Models
{
    public class NewCartProductsModel
    {
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; } = "";

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}
    
