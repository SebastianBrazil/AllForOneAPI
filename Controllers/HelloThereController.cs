using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services.HelloThere;

namespace AllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloThereController : ControllerBase
{
    private readonly IHelloThereService _helloThereService;

    public HelloThereController(IHelloThereService helloThereService)
    {
        _helloThereService = helloThereService;
    }

    [HttpGet]
    [Route("{name}")]
    public string HelloThere(string name)
    {
        return _helloThereService.HelloThere(name);
    }
}
