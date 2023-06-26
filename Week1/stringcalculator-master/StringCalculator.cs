
namespace StringCalculator;

public class StringCalculator
{
    string customDelimiter = "//";
    public int Add(string numbers)
    {
        
        if(numbers.Length == 0)
        {
            return 0;
        }
        else if(numbers.Length == 1)
        {
            return int.Parse(numbers);
        } 
        else
        {
            int sum = 0;
            if (numbers.StartsWith(customDelimiter))
            {
                int delimiterIntex = numbers.IndexOf(customDelimiter) + 2;
                string delimiter = numbers.Substring(delimiterIntex, delimiterIntex + 1);
                string numbersWODelimiter = numbers.Substring(numbers.IndexOf("\n"));

                string[] numberArray = numbersWODelimiter.Split(delimiter);

                foreach(string number in numberArray)
                {
                    sum += int.Parse(number);
                }
            }
            else
            {
                char[] delimiterChars = { ',', '\n' };
                string[] numberArray = numbers.Split(delimiterChars);
                foreach (string number in numberArray)
                {
                    sum += int.Parse(number);
                }
            }
            return sum;
        }
    }
}
