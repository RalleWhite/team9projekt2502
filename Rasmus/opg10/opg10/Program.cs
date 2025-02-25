namespace opg10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast ugedag (tal): ");
            int nDay = Convert.ToInt32(Console.ReadLine());

            switch (nDay)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;
                case 2:
                    Console.WriteLine("Tirsdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lørdag");
                    break;
                case 7:
                    Console.WriteLine("Søndag");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ugyldigt input. Indtast et tal mellem 1 og 7.");
                    break;
            }
            Thread.Sleep(3000);
        }
    }
}
