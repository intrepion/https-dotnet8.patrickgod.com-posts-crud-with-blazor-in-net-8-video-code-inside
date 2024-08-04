using BlazorCrudDotNet8.Data;
using BlazorCrudDotNet8.Entities;
using BlazorCrudDotNet8.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Services;

public class GameService(DataContext context) : IGameService
{
    private readonly DataContext _context = context;

    public async Task<List<Game>> GetAllGames()
    {
        await Task.Delay(1000);

        var games = await _context.Games.ToListAsync();

        return games;
    }
}
