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
                if (isUpper(name) && !(isUpper(names.First())))
                {
                    return $"Hello, {names.First()} AND {name}!";
                }
                else if (isUpper(names.First()) && !(isUpper(name)))
                {
                    return $"Hello, {name} AND {names.First()}!";
                }
                else if (isUpper(names.First()) && isUpper(name))
                {
                    return $"HELLO, {name} AND {names.First()}!";
                }
                return $"Hello, {name} and {names.First()}!";
            }
            else
            {
                if (IsEverythingUpper(name, names))
                {
                    var output = $"HELLO, {name}";
                    foreach (string n in names)
                    {
                        if (n != names.Last())
                        {
                            output += $", {n}";
                        }
                        else
                        {
                            output += $", AND {n}!";
                        }
                    }
                    return output;
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
        }

        protected bool IsEverythingUpper(string? name, string[] names)
        {
            if(isUpper(name))
            {
                foreach(string n in names)
                {
                    if (!(isUpper(n)))
                    {
                        return false;
                    } 
                }
            } 
            else
            {
                return false;
            }
            return true;
        }

        //Format for singular name
        protected string RegularFormat(string? name) 
        {
            if (name == null) { return "Hello, Buddy!"; }

            if (isUpper(name))
            {
                return $"HELLO, {name}!";
            }
            return $"Hello, {name}!";
        }

        protected bool isUpper(string? name)
        {
            if (name.ToUpper() == name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}