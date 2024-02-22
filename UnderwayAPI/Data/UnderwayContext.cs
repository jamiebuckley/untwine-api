using Microsoft.EntityFrameworkCore;
using UnderwayAPI.Models;

namespace UnderwayAPI.Data;

public class UnderwayContext : DbContext
{
    public UnderwayContext(DbContextOptions<UnderwayContext> options) : base(options)
    {
        
    }
    
    public DbSet<Pipeline> Pipelines { get; set; }
}