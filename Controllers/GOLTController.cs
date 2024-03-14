using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services.GOLT;

namespace AllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GOLTController : ControllerBase
{
    private readonly IGOLTService _gOLTService;

    public GOLTController(IGOLTService gOLTService)
    {
        _gOLTService = gOLTService;
    }

    [HttpGet]
    [Route("{num1}/{num2}")]
    public string GOLT(string num1, string num2)
    {
        return _gOLTService.GOLT(num1, num2);
    }
}
