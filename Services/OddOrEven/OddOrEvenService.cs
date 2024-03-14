namespace AllForOneAPI.Services.OddOrEven;

public class OddOrEvenService : IOddOrEvenService
{
    public string OddOrEven(string num)
    {
        if (!double.TryParse(num, out double parsedNum))
        {
            return "Your input was not a valid number. It is not comparable.";
        }
        else
        {
            if (parsedNum % 2 == 0)
            {
                return $"{parsedNum} is an even number. Yippee";
            }
            else
            {
                return $"{parsedNum} is an odd number. Yippee";
            }
        }
    }
}