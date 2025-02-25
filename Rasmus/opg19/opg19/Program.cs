using System.Text.RegularExpressions;

namespace opg19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv input du vil finde vokaler i!");
            string input = Console.ReadLine();
            string pattern = @"[aeiou]";
            foreach (Match match in Regex.Matches(input, pattern))
                Console.WriteLine(match.Value);
            
            Thread.Sleep(8000);
        }
    }
}
