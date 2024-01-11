using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using benchTime.Models;

namespace benchTime.Data;

 
public class DataContext : DbContext
// : IdentityDbContext<User>
{
    public virtual DbSet<Bench> Benches { get; set; } = null!;
    public DataContext(DbContextOptions<DataContext> options)
: base(options)
    {
    }
}