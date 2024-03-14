using static System.Environment;

namespace AllForOneAPI.Services.ReverseNum;

public class ReverseNumService : IReverseNumService
{
    public string ReverseNum(string userInput)
    {
        if (int.TryParse(userInput, out int numero1))
        {
            int result = 0;
            while (numero1 > 0)
            {
                result = result * 10 + numero1 % 10;
                numero1 /= 10;
            }
            if(Convert.ToString(userInput[0]) == "0"){
                string strResult = Convert.ToString(result);
                strResult+="0";
                result = Convert.ToInt32(strResult);
            }
            return $"You chose the number {userInput}." + NewLine + $"The reverse of {userInput} is {result}.";
        }
        else
        {
            return $"{userInput} is not a clear numerical sequence.";
        }
    }
}