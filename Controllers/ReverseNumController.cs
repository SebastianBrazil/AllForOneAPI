using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services.ReverseNum;

namespace AllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseNumController : ControllerBase
{
    private readonly IReverseNumService _reverseNumService;

    public ReverseNumController(IReverseNumService reverseNumService)
    {
        _reverseNumService = reverseNumService;
    }

    [HttpGet]
    [Route("{userInput}")]
    public string ReverseNum(string userInput)
    {
        return _reverseNumService.ReverseNum(userInput);
    }
}
