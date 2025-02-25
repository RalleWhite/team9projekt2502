namespace opg12_13_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop");
            for (int ia = 1; ia <= 10; ia++)
            {
                Console.WriteLine(ia);
            }
            
            Thread.Sleep(3000);


            int ib = 1;
            Console.WriteLine("\nWhile loop");
            while (ib <= 10)
            {
                Console.WriteLine(ib);
                ib++;
            }

            Thread.Sleep(3000);


            int ic = 1;
            Console.WriteLine("\nDo-while loop");
            do
            {
                Console.WriteLine(ic);
                ic++;
            }
            while (ic <= 10);

            Thread.Sleep(5000);
        }
    }
}
