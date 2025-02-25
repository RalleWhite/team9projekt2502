namespace opg16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et tal du vil have fakulteten af (Tal fra 0-66 supported");
            uint n = Convert.ToUInt32(Console.ReadLine());
            ulong fResult = Factorial(n);
            Console.WriteLine("Fakulteten af "+n+" er: "+fResult);
            Thread.Sleep(3000);
        }

        static ulong Factorial(uint n)
        {
            if (n < 0)
                Console.WriteLine("Indtastning skal være et positivt tal");
            if (n == 0 || n == 1)
                return 1;
            ulong factorial = 1;
            for (uint i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
