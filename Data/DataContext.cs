using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options) // Use Primary Constructor 
{
    public DbSet<AppUser> Users { get; set; }
}