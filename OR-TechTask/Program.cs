namespace OR_TechTask;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the string to be manipulated:");
        var input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be null or empty.");
            return;
        }

        Console.WriteLine($@"{StringManipulator.Manipulator(input)}");
    }
}

public class StringManipulator
{
    public static string Manipulator(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Input string cannot be null or empty.");
        }

        return $@"{ReverseString(input)}{FindEarliestCharacter(input)}{ReturnRentOrOpenFromVowelTotal(input)}";
    }

    public static string ReverseString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Input string cannot be null or empty.");
        }

        char[] charArray = input.ToCharArray(); //I can't see a reason not to allow any input, hence no trimming or removal of non-letter characters
        Array.Reverse(charArray);

        return new string(charArray);
    }

    public static char FindEarliestCharacter(string input) //I consider "earliest" to mean the letter that comes first in the alphabet, regardless of case, and not any other type of character
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Input string cannot be null or empty.");
        }

        if (!input.Any(char.IsLetter)) //ensures there is at least one valid letter provided
        {
            throw new ArgumentException("Input string must contain at least one letter.");
        }

        var earliestLetter = input.Where(char.IsLetter) //ignores non-letter characters
                .Min(char.ToLowerInvariant);

        return input.Contains(earliestLetter) ? earliestLetter : char.ToUpperInvariant(earliestLetter); //preserves the character's case
    }

    public static string ReturnRentOrOpenFromVowelTotal(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Input string cannot be null or empty.");
        }

        var vowelCount = input.Count(x => char.ToUpperInvariant(x) == 'A'
                                        || char.ToUpperInvariant(x) == 'E'
                                        || char.ToUpperInvariant(x) == 'I'
                                        || char.ToUpperInvariant(x) == 'O'
                                        || char.ToUpperInvariant(x) == 'U');

        return vowelCount % 2 == 0 ? "rent" : "open"; //I am classing 0 as even, i.e. rent will be returned in cases with no vowels
    }
}