using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen_Endpoints.Services.GuessIt;

namespace MiniChallengeEightToTen_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class GuessItController : ControllerBase
{
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }

    [HttpGet]
    [Route("EnterANumber/{number}")]
    public string GuessItEasy(string number){
        return _guessItService.GuessItEasy(number);
    }

    public string GuessItMedium(string number){
        return _guessItService.GuessItMedium(number);
    }

    public string GuessItHard(string number){
        return _guessItService.GuessItHard(number);
    }

}
