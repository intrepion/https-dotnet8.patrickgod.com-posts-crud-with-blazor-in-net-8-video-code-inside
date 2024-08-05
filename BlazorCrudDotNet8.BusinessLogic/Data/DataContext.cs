using BlazorCrudDotNet8.BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.BusinessLogic.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Game> Games { get; set; }
}
