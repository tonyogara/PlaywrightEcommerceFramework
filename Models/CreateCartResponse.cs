using System.Text.Json.Serialization;

namespace PlaywrightEcommerceFramework.Models;
public class CreateCartResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
}