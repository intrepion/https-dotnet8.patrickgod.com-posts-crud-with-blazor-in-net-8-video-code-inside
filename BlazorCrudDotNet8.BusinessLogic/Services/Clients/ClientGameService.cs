using System.Net.Http.Json;
using BlazorCrudDotNet8.BusinessLogic.Entities;
using BlazorCrudDotNet8.BusinessLogic.Services.Interfaces;

namespace BlazorCrudDotNet8.BusinessLogic.Services.Clients;

public class ClientGameService(HttpClient httpClient) : IGameService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<Game> AddGame(Game game)
    {
        var result = await _httpClient.PostAsJsonAsync("/api/game", game);

        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public Task<List<Game>> GetAllGames()
    {
        throw new NotImplementedException();
    }
}