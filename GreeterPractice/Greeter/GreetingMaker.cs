namespace Greeter
{
    public class GreetingMaker
    {
        public GreetingMaker()
        {
        }

        public string Greet(string? name, params string[] names)
        {
            if (names.Length > 1)
            {
                var output = $"Hello, {name}";
                foreach (string n in names)
                {
                    if (n != names.Last())
                    {
                        output += $", {n}";
                    }
                    else
                    {
                        output += $", and {n}!";
                    }
                }
                return output;
            }
            if (names.Length  == 1) { return $"Hello, {name} and {names.First()}!"; }

            if (name == null) { return "Hello, Buddy!";  }

            if (name.ToUpper() == name)
            {
                return $"HELLO, {name}!";
            }
            return $"Hello, {name}!";
        }
    }
}