using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services.RP;

namespace AllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RPController : ControllerBase
{
    private readonly IRPService _rPService;

    public RPController(IRPService rPService)
    {
        _rPService = rPService;
    }

    [HttpGet]
    [Route("{category}")]
    public string Pick(string category)
    {
        return _rPService.Pick(category);
    }
}
