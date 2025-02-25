namespace opg5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast radius for cirklen:");
            double radius = Convert.ToDouble(Console.ReadLine());

            if (radius <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Radius skal være større end 0.");
                Thread.Sleep(2000);
            }
            else
            {
                double pi = Math.PI;
                double area = pi * Math.Pow(radius, 2);
                double circumference = 2 * pi * radius;

                Console.WriteLine("Areal af cirklen: " + area);
                Console.WriteLine("Omkreds af cirklen: " + circumference);
                Thread.Sleep(5000);
            }
        }
    }
}
