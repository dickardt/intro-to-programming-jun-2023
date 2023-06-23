namespace Greeter
{
    public class GreetingMaker
    {
        public GreetingMaker()
        {
        }

        public string Greet(string? name, string? newName = null)
        {
            if (newName != null) { return $"Hello, {name} and {newName}!"; }
            if (name == null) { return "Hello, Buddy!";  }

            if (name.ToUpper() == name)
            {
                return $"HELLO, {name}!";
            }
            return $"Hello, {name}!";
        }
    }
}