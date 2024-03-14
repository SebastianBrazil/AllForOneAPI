using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services.SomeQuestions;

namespace AllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SomeQuestionsController : ControllerBase
{
    private readonly ISomeQuestionsService _someQuestionsService;

    public SomeQuestionsController(ISomeQuestionsService someQuestionsService)
    {
        _someQuestionsService = someQuestionsService;
    }

    [HttpGet]
    [Route("{name}/{time}")]
    public string SomeQuestions(string name, string time)
    {
        return _someQuestionsService.SomeQuestions(name, time);
    }
}