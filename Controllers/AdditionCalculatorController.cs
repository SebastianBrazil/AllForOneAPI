using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services.AdditionCalculator;

namespace AllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AdditionCalculatorController : ControllerBase
{
    private readonly IAdditionCalculatorService _additionCalculatorService;

    public AdditionCalculatorController(IAdditionCalculatorService additionCalculatorService)
    {
        _additionCalculatorService = additionCalculatorService;
    }

    [HttpGet]
    [Route("{number1}/{number2}")]
    public string AdditionCalculator(string number1, string number2)
    {
        return _additionCalculatorService.AdditionCalculator(number1, number2);
    }
}
