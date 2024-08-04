using Microsoft.EntityFrameworkCore;
using BlazorCrudDotNet8.BusinessLogic.Entities;

namespace BlazorCrudDotNet8.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Game> Games { get; set; }
}
