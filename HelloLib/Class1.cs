namespace HelloLib;

public class HelloService
{
    public string Greeting(string name = "world")
    {
        return $"Hello {name}!";
    }
}
