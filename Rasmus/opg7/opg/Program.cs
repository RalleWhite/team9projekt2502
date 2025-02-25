namespace opg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et tal: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Tallet er positivt.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Tallet er negativt.");
            }
            else
            {
                Console.WriteLine("Tallet er nul.");
            }
            Thread.Sleep(3000);
        }
    }
}
