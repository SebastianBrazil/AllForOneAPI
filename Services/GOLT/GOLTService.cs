using static System.Environment;

namespace AllForOneAPI.Services.GOLT;

public class GOLTService : IGOLTService
{
    public string GOLT(string num1, string num2)
    {
        if (!double.TryParse(num1, out double parsedNum1) || !double.TryParse(num2, out double parsedNum2))
        {
            return "One of your inputs was not a valid number. They are not comparable.";
        }
        else
        {
            if (parsedNum1 == parsedNum2)
            {
                return $"The first number, {parsedNum1}, is equal to the second number, {parsedNum2}. Why did you put the same number twice?" + NewLine + $"The second number, {parsedNum2}, is equal to the first number, {parsedNum1}. How dare you put the same number twice?";
            }
            else if (parsedNum1 < parsedNum2)
            {
                return $"The first number, {parsedNum1}, is less than the second number, {parsedNum2}. It is a small number." + NewLine + $"The second number, {parsedNum2}, is greater than the first number, {parsedNum1}. It is a big number.";
            }
            else
            {
                return $"The first number, {parsedNum1}, is greater than the second number, {parsedNum2}. It is a big number." + NewLine + $"The second number, {parsedNum2}, is less than the first number, {parsedNum1}. It is a small number.";
            }
        }
    }
}