namespace opg18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv sætning du ønsker omvendt!");
            string input = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[input.Length - i - 1]);
            }
            Thread.Sleep(5000);
        }
    }
}
