using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen_Endpoints.Services.EightBall;

namespace MiniChallengeEightToTen_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class EightBallController : ControllerBase
{
    private readonly IEightBallService _eightBallService;

    public EightBallController(IEightBallService eightBallService)
    {
        _eightBallService = eightBallService;
    }

    [HttpGet]
    [Route("AskMeAnything/{yourQuestion}")]
    public string AskMe(string yourQuestion)
    {
        return _eightBallService.AskMe(yourQuestion);
    }
}
