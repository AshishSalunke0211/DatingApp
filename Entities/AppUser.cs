namespace API.Entities;

public partial class AppUser 
{
    public int Id { get; set; } // It is primitive datatype and its not set to null // it set to 0
    public required string UserName { get; set; } // It is refernce type and its nullable to avoid it set to required

    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
}