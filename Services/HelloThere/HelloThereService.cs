namespace AllForOneAPI.Services.HelloThere;

public class HelloThereService : IHelloThereService
{
    public string HelloThere(string name)
    {
        return $"Hello there, {name}";
    }
}
