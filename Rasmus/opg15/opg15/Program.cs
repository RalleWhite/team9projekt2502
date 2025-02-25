namespace opg15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beregn sum indtil (Indsæt heltal): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int sum = 0;

            while (i <= n)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Summen af alle tal fra 1 til "+n+" er: "+sum);
            Thread.Sleep(5000);
        }
    }
}
