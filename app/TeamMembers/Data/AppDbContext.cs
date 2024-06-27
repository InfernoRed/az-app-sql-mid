using Microsoft.EntityFrameworkCore;
using TeamMembers.Data.Models;

namespace TeamMembers.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Person> People { get; set; }
}
