using BlazorCrudDotNet8.BusinessLogic.Entities;
using BlazorCrudDotNet8.BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotNet8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameController(IGameService gameService) : ControllerBase
{
    private readonly IGameService _gameService = gameService;

    [HttpPost]
    public async Task<ActionResult<Game>> AddGame(Game game)
    {
        var addedGame = await _gameService.AddGame(game);

        return Ok(addedGame);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Game>> DeleteGame(int id)
    {
        var addedGame = await _gameService.DeleteGame(id);

        return Ok(addedGame);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Game>> EditGame(int id, Game game)
    {
        var result = await _gameService.EditGame(id, game);

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> GetGameById(int id)
    {
        var game = await _gameService.GetGameById(id);

        return Ok(game);
    }
}
