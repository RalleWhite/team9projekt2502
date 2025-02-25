namespace opg4_op6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matematik Program");
            Console.WriteLine("Indtast tal A");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast tal B");
            int numB = Convert.ToInt32(Console.ReadLine());
            if (numA != 0 && numB != 0)
            {

                int s = numA + numB;
                int d = numA - numB;
                int p = numA * numB;
                int q = numA / numB;
                int r = numA % numB;
                Console.WriteLine("Sum: " + s + ", Difference: " + d + ", Product: " + p + ", Quotient: " + q + ", Remainder: " + r);

                bool isEqual = numA == numB;
                bool isNotEqual = numA != numB;
                bool isGreater = numA > numB;
                bool isLess = numA < numB;
                bool isGreaterOrEqual = numA >= numB;
                bool isLessOrEqual = numA <= numB;
                Console.WriteLine("Is Equal: " + isEqual + ", Is Not Equal: " + isNotEqual + ", Is Greater: " + isGreater + ", Is Less: " + isLess + ", Is Greater or Equal: " + isGreaterOrEqual + ", Is Less or Equal: " + isLessOrEqual);

                Thread.Sleep(7500);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ugyldigt Input!");
                Thread.Sleep(2000);
            }
        }
    }
}
