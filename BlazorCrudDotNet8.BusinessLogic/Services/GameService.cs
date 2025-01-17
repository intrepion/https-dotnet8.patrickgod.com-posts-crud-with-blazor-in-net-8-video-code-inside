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

    public async Task<bool> DeleteGame(int id)
    {
        var dbGame = await _context.Games.FindAsync(id);
        if (dbGame != null)
        {
            _context.Remove(dbGame);
            await _context.SaveChangesAsync();

            return true;
        }

        return false;
    }

    public async Task<Game> EditGame(int id, Game game)
    {
        var dbGame = await _context.Games.FindAsync(id);
        if (dbGame != null)
        {
            dbGame.Name = game.Name;
            await _context.SaveChangesAsync();

            return dbGame;
        }

        throw new Exception("Game not found.");
    }

    public async Task<List<Game>> GetAllGames()
    {
        await Task.Delay(1000);

        var games = await _context.Games.ToListAsync();

        return games;
    }

    public async Task<Game> GetGameById(int id)
    {
        return await _context.Games.FindAsync(id);
    }
}
