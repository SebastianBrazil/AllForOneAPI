using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services.Magic8Ball;

namespace AllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    private readonly IMagic8BallService _magic8BallService;

    public Magic8BallController(IMagic8BallService magic8BallService)
    {
        _magic8BallService = magic8BallService;
    }

    [HttpGet]
    [Route("{question}")]
    public string Ask(string question)
    {
        return _magic8BallService.Ask(question);
    }
}
