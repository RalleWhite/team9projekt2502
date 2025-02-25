namespace opg2
{
    internal class Program
    {
        static int tempCalc(int temp, char tempType)
        {
            if (tempType == 'C')
            {
                return (int)(temp*(9.0/5)+32); // C til F
            }
            else if (tempType == 'F')
            {
                return (int)((temp-32)*(5.0/9)); // F til C
            }
            else
            {
                Console.WriteLine("Ugyldig temperaturtype!");
                return temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til temp omregneren!");
            Console.Write("Indtast venligst en temperaturtype (C/F): ");
            char tempType = char.ToUpper(Console.ReadLine()[0]);

            Console.Write("Indtast venligst en temperatur i "+tempType+"°: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            int convertedTemp = tempCalc(temp, tempType);

            if (tempType == 'C')
                Console.WriteLine(temp+"°C er "+convertedTemp+"°F.");
            else if (tempType == 'F')
                Console.WriteLine(temp+"°F er "+convertedTemp+"°C.");


            if (convertedTemp == -40)
            {
                Console.WriteLine("Den nye temperatur er det samme som den originale input temperatur! (Grundet skalaerne mødes)");
            }
            else if (tempType == 'C' && convertedTemp <= 0 || tempType == 'F' && convertedTemp <= 32)
            {
                Console.WriteLine("Vandet Fryser!");
            }
            else if (tempType == 'C' && convertedTemp >= 100 || tempType == 'F' && convertedTemp <= 212)
            {
                Console.WriteLine("Vandet Koger!");
            }

            Thread.Sleep(7500);
        }

    }
}