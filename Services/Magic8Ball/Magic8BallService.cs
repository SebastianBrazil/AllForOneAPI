using static System.Environment;

namespace AllForOneAPI.Services.Magic8Ball;

public class Magic8BallService : IMagic8BallService
{
    public string Ask(string question)
    {
        Random numby = new Random();
        int bobbert = numby.Next(0,8);

        string[] response = new string[8];
        response[0] = "It is decisively so";
        response[1] = "More than likely, yes";
        response[2] = "Outlook seems positive";
        response[3] = "Concentrate on your question, and ask again";
        response[4] = "It is better if you don't know";
        response[5] = "Perchance";
        response[6] = "My sources say no";
        response[7] = "Don't count on it";

        return question + "?" + NewLine + response[bobbert];
    }
}