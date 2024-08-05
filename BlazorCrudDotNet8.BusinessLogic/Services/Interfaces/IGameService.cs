using BlazorCrudDotNet8.BusinessLogic.Entities;

namespace BlazorCrudDotNet8.BusinessLogic.Services.Interfaces;

public interface IGameService
{
    Task<Game> AddGame(Game game);
    Task<List<Game>> GetAllGames();
}