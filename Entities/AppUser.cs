using API.Extensions;

namespace API.Entities;

public partial class AppUser
{
    public int Id { get; set; } // It is primitive datatype and its not set to null // it set to 0
    public required string UserName { get; set; } // It is refernce type and its nullable to avoid it set to required

    public byte[] PasswordHash { get; set; } = [];
    public byte[] PasswordSalt { get; set; } = [];

    public DateOnly DateOfBirth { get; set; }
    public required string KnownAs { get; set; }

    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime LastActive { get; set; } = DateTime.UtcNow;
    public required string Gender { get; set; }
    public string? Introduction { get; set; }
    public string? Interests { get; set; }
    public string? LookingFor { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public List<Photo> Photos {get; set;} = [];

    // public int GetAge()
    // {
    //     return DateOfBirth.CalculateAge();
    // }
}
