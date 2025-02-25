namespace opg11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast en måned (tal fra 1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("Januar - Det er vinter. Der er ofte koldt, og vi kan få sne. Nyttårsforsætter og begyndelsen af året.");
                    break;
                case 2:
                    Console.WriteLine("Februar - Vinteren fortsætter, og vi kan forvente kolde dage. Der er vinterferie for mange skoleelever.");
                    break;
                case 3:
                    Console.WriteLine("Marts - Forårsmåneden begynder. Vi får længere dage, og der er chancer for tidlige forårsblomster.");
                    break;
                case 4:
                    Console.WriteLine("April - April bringer både sol og regn. Foråret er godt i gang, og påsken fejres ofte i denne måned.");
                    break;
                case 5:
                    Console.WriteLine("Maj - Foråret er på sit højeste, og vejret bliver varmere. Det er tid til at nyde naturen, og der er ofte fridage.");
                    break;
                case 6:
                    Console.WriteLine("Juni - Sommeren begynder. Der er lange lyse dage, og mange fejrer Sankt Hans aften med bål.");
                    break;
                case 7:
                    Console.WriteLine("Juli - Højsommer. Mange tager på ferie, og vi kan forvente varmt vejr. Perfekt til strand og udendørs aktiviteter.");
                    break;
                case 8:
                    Console.WriteLine("August - Sommerferien slutter, og skolerne begynder igen. Vejret er stadig varmt, men sommeren er ved at være slut.");
                    break;
                case 9:
                    Console.WriteLine("September - Efterår er begyndt. Vi får køligere vejr, og bladene på træerne begynder at ændre farve.");
                    break;
                case 10:
                    Console.WriteLine("Oktober - Efteråret er i fuld gang. Der er ofte kølige dage, og Halloween begynder at blive populært.");
                    break;
                case 11:
                    Console.WriteLine("November - Der bliver koldere og mørkere. Vi ser mere regn og måske sne. Julefrokosterne begynder for nogle.");
                    break;
                case 12:
                    Console.WriteLine("December - Vintermåneden. Julen nærmer sig, og vi fejrer højtiden med familier og lysdekorationer.");
                    break;
                default:
                    Console.WriteLine("Ugyldigt input. Indtast et tal mellem 1-12.");
                    break;
            }
            Thread.Sleep(7500);

            /*
            DISCLAIMER!
            Teksten der beskriver måneder er genereret med ChatGPT
             */
        }
    }
}
