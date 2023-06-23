namespace Greeter
{
    public class GreetingMaker
    {
        public GreetingMaker()
        {
        }

        public string Greet(string? name)
        {
            if (name == null) { return "Hello, Buddy";  }
            return $"Hello, {name}";
        }
    }
}