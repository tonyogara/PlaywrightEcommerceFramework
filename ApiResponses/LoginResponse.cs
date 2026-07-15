using System.Text.Json.Serialization;

namespace PlaywrightEcommerceFramework.ApiResponses;
public class LoginResponse
{
    //public string access_token { get; set; } = "";


[JsonPropertyName("access_token")]
    public string Token { get; set; } = "";


/*
    [JsonPropertyName("email")]
    public string Email { get; set; } = "";
    */


/*
 "token_type": "Bearer",
  "expires_in": 120
  */


}