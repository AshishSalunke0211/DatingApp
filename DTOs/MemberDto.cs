namespace API.DTOs;

public class MemberDto
{
    public int Id { get; set; } // It is primitive datatype and its not set to null // it set to 0
    public string? UserName { get; set; } // It is refernce type and its nullable to avoid it set to required

    public int Age { get; set; }
    public string? PhotoUrl { get; set; }
    public string? KnownAs { get; set; }

    public DateTime Created { get; set; } 
    public DateTime LastActive { get; set; } 
    public string? Gender { get; set; }
    public string? Introduction { get; set; }
    public string? Interests { get; set; }
    public string? LookingFor { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public List<PhotoDto>? Photos {get; set;} = [];

}
