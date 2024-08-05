using BlazorCrudDotNet8.BusinessLogic.Entities;

namespace BlazorCrudDotNet8.BusinessLogic.Services.Interfaces;

public interface IGameService
{
    Task<Game> AddGame(Game game);
    Task<bool> DeleteGame(int id);
    Task<Game> EditGame(int id, Game game);
    Task<List<Game>> GetAllGames();
    Task<Game> GetGameById(int id);
}