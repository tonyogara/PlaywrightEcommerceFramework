using System.Text.Json.Serialization;

namespace PlaywrightEcommerceFramework.Models;

public class LoginResponse
{
    [JsonPropertyName("access_token")]
    public string Token { get; set; } = string.Empty;

    [JsonPropertyName("token_type")]
    public string TokenType { get; set; } = string.Empty;

    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }
}