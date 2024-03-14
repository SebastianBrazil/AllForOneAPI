namespace AllForOneAPI.Services.SomeQuestions;

public class SomeQuestionsService : ISomeQuestionsService
{
    public string SomeQuestions(string name, string time)
    {
        return $"Your name is {name} and you woke up at {time}. You slept in.";
    }
}