using BlazorCrudDotNet8.Entities;

namespace BlazorCrudDotNet8.Services.Interfaces;

public interface IGameService
{
    Task<List<Game>> GetAllGames();
}