namespace opg17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv det første tal!");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv det andet tal!");
            int numB = Convert.ToInt32(Console.ReadLine());

            int result = Sum(numA, numB);
            Console.WriteLine("Summen af "+numA+" og "+numB+" er: "+result);
            Thread.Sleep(5000);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
