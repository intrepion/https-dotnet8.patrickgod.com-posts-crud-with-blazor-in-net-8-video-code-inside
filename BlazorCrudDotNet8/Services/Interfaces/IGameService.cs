using BlazorCrudDotNet8.Entities;

namespace BlazorCrudDotNet8.Services.Interfaces;

public interface IGameService
{
    Task<Game> AddGame(Game game);
    Task<List<Game>> GetAllGames();
}