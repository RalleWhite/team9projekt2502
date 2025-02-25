namespace opg3
{
    internal class Program
    {
        static double bmiCalc(double weight, int heightCm)
        {
            if (weight <= 0 || heightCm <= 0)
            {
                Console.WriteLine("Ugyldig vægt eller højde!");
                return 0;
            }

            double heightM = heightCm / 100.0;
            return weight / Math.Pow(heightM, 2);
        }
        static string bmiCat(double bmi)
        {
            if (bmi < 18.5)
                return "Undervægtig";
            else if (bmi >= 18.5 && bmi < 25)
                return "Normalvægtig";
            else if (bmi >= 25 && bmi < 30)
                return "Overvægtig";
            else
                return "Fedme";
        }
        static void Main()
        {
            Console.Write("Indtast din vægt i kg: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast din højde i cm: ");
            int height = Convert.ToInt32(Console.ReadLine());

            double bmi = bmiCalc(weight, height);

            if (bmi > 0)
            {
                string category = bmiCat(bmi);
                Console.WriteLine("Dit BMI er: "+bmi);
                Console.WriteLine("Du ligger indefor kategorien: "+category);
            }

            Thread.Sleep(7500);
        }

    }
}

