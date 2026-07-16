using PlaywrightEcommerceFramework.Models; // Replace 'YourNamespace' with the actual namespace containing NewUser


namespace PlaywrightEcommerceFramework.Models
{
    public class ShoppingTestContext
    {
        public NewUser User { get; set; } = new();
        public string Token { get; set; } = "";
        public string CartId { get; set; } = "";
        public string ProductId { get; set; } = "";
    }
}

    /*
    public string Emaill { get; set; } = "";

     public string Password { get; set; } = "";
    public string Token { get; set; } = "";
    public string CartId { get; set; } = "";
    public string ProductId { get; set; } = "";
    */


