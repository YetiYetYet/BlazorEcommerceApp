namespace BlazorEcommerce.Shared;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public Address Address { get; set; }
    public string Role { get; set; } = "Customer";
}