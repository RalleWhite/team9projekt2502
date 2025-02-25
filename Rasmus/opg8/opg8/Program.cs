namespace opg8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast din karakter (A-F):");
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());

            bool isPassed = IsPassed(grade);

            if (isPassed)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du har bestået.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du har ikke bestået.");
            }
            Thread.Sleep(3000);
        }
        static bool IsPassed(char grade)
        {
            return (grade == 'A' || grade == 'B' || grade == 'C' || grade == 'D' || grade == 'E');
        }

    }
}
