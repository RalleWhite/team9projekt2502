namespace _25feb25
{
    internal class Program
    {
        static string name = "Mark";
        static int age = 30;
        static double height = 1.90;
        static double weight = 75.2;
        static char initial = name[0];
        static bool studentStatus = true;
        static string occupation = "";
        
        static void Main(string[] args)
        {
            if (studentStatus == true) {
                string occupation = "studerende";
            }
            else {
                string occupation = "ledig";
            }

            Console.WriteLine("Ønsket Output: \nAge: "+age+", Height: "+height+", Weight: "+weight+", Initial: "+initial+", Name: "+name+", Is Student: "+studentStatus);

            Console.WriteLine("\n\nCustom Output: \n\nEleven hedder "+name+" ("+initial+") og er "+age+" år gammel. \nDerudover er "+name+" "+height+" høj, vejer "+weight+" og er lige nu "+occupation+ "");
            
            Console.ReadLine();
        }
    }
}
