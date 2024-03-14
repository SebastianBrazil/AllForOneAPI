using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services.OddOrEven;

namespace AllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
    [Route("{num}")]
    public string OddOrEven(string num)
    {
        return _oddOrEvenService.OddOrEven(num);
    }
}