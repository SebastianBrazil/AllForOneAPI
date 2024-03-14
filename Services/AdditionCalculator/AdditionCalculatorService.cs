namespace AllForOneAPI.Services.AdditionCalculator;

public class AdditionCalculatorService : IAdditionCalculatorService
{
    public string AdditionCalculator(string number1, string number2)
    {
        if (!double.TryParse(number1, out double parsedNum1) || !double.TryParse(number2, out double parsedNum2))
        {
            return "One of your inputs was not a valid number. No tax return for you.";
        }
        else
        {
            return $"{parsedNum1} and {parsedNum2} added together is equal to {parsedNum1 + parsedNum2}.";
        }
    }
}
