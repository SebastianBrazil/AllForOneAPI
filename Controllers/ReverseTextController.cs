using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services.ReverseText;

namespace AllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseTextController : ControllerBase
{
    private readonly IReverseTextService _reverseTextService;

    public ReverseTextController(IReverseTextService reverseTextService)
    {
        _reverseTextService = reverseTextService;
    }

    [HttpGet]
    [Route("{userInput}")]
    public string ReversePhrase(string userInput)
    {
        return _reverseTextService.ReversePhrase(userInput);
    }
}
