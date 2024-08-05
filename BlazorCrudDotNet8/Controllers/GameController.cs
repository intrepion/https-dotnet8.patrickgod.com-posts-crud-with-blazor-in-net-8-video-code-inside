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
}
