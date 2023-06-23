namespace Greeter
{
    public class GreetingMaker
    {
        public GreetingMaker()
        {
        }

        public string Greet(string? name, params string[] names)
        {
            var output = "";
            if (names.Length >= 1)
            {
                output = MultipleNames(name, names); 
            } 
            else
            {
                output = RegularFormat(name);
            }
            return output;   
        }
        //Format string for multiple names
        protected string MultipleNames(string? name, string[] names)
        {
            if (names.Length == 1) 
            { 
                return $"Hello, {name} and {names.First()}!";
            }
            else
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
        }
        //Format for singular name
        protected string RegularFormat(string? name) 
        {
            if (name == null) { return "Hello, Buddy!"; }

            if (name.ToUpper() == name)
            {
                return $"HELLO, {name}!";
            }
            return $"Hello, {name}!";
        }
    }
}