namespace opg9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et år for at tjekke, om det er et skudår:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (IsLeapYear(year))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(year+" er et skudår.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(year+" er ikke et skudår.");
            }
            Thread.Sleep(3000);
        }

        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
