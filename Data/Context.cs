using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AssignProject.Models;

public class Context : IdentityDbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {

    }
    public DbSet<Pet> Pet { get; set; } = default!;

}