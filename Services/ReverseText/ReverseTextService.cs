namespace AllForOneAPI.Services.ReverseText;

public class ReverseTextService : IReverseTextService
{
    public string ReversePhrase(string userInput)
    {
        string reversedUserInput = "";
        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            reversedUserInput += userInput[i];
        }
        return $"You chose the phrase {userInput}. The reverse of {userInput} is {reversedUserInput}";
    }
}