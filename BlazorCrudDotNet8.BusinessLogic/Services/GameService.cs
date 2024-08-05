using BlazorCrudDotNet8.BusinessLogic.Data;
using BlazorCrudDotNet8.BusinessLogic.Entities;
using BlazorCrudDotNet8.BusinessLogic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.BusinessLogic.Services;

public class GameService(DataContext context) : IGameService
{
    private readonly DataContext _context = context;

    public async Task<Game> AddGame(Game game)
    {
        _context.Games.Add(game);
        await _context.SaveChangesAsync();

        return game;
    }

    public async Task<List<Game>> GetAllGames()
    {
        await Task.Delay(1000);

        var games = await _context.Games.ToListAsync();

        return games;
    }
}
