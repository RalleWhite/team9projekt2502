namespace CarAppMarts
{
    using System;

    namespace CarApp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // Opret et nyt Car-objekt
                Car myCar = new Car("Toyota", "Corolla", 2020, 'A', "Benzin", 18.5);

                // Udskriv bilens detaljer
                myCar.PrintCarDetails();

                // Start motoren og kør en tur
                myCar.StartEngine();
                myCar.Drive(50);

                // Beregn turpris
                double tripPrice = myCar.CalculateTripPrice(50, 14.99);
                Console.WriteLine($" Turen koster: {tripPrice:F2} kr.");

                // Stop motoren og udskriv bilens detaljer igen
                myCar.StopEngine();
                myCar.PrintCarDetails();
            }
        }
    }
    namespace CarApp

    {
        public class Car
        {
            // Private attributter (indkapsling)
            private string brand;
            private string model;
            private int year;
            private char gear;
            private int odometer;
            private string fuelType;
            private bool isEngineOn;
            private double kmPerLiter;

            // Konstruktør
            public Car(string brand, string model, int year, char gear, string fuelType, double kmPerLiter)
            {
                this.brand = brand;
                this.model = model;
                this.year = year;
                this.gear = gear;
                this.fuelType = fuelType;
                this.kmPerLiter = kmPerLiter;
                this.odometer = 0; // Starter på 0 km
                this.isEngineOn = false; // Motor starter som slukket
            }

            // Getters og Setters for at kontrollere adgang til attributterne
            public string Brand { get { return brand; } }
            public string Model { get { return model; } }
            public int Year { get { return year; } }
            public char Gear { get { return gear; } }
            public int Odometer { get { return odometer; } }
            public string FuelType { get { return fuelType; } }
            public bool IsEngineOn { get { return isEngineOn; } }

            // Metode til at starte motoren
            public void StartEngine()
            {
                isEngineOn = true;
                Console.WriteLine(" Motoren er startet.");
            }

            // Metode til at stoppe motoren
            public void StopEngine()
            {
                isEngineOn = false;
                Console.WriteLine(" Motoren er stoppet.");
            }

            // Metode til at køre bilen
            public void Drive(double distance)
            {
                if (isEngineOn)
                {
                    odometer += (int)distance;
                    Console.WriteLine($" Bilen har kørt {distance} km. Ny kilometertæller: {odometer} km.");
                }
                else
                {
                    Console.WriteLine(" Du kan ikke køre, motoren er slukket!");
                }
            }

            // Beregner prisen for en tur
            public double CalculateTripPrice(double distance, double literPrice)
            {
                if (kmPerLiter > 0)
                {
                    double fuelNeeded = distance / kmPerLiter;
                    return fuelNeeded * literPrice;
                }
                else
                {
                    Console.WriteLine(" Denne bil bruger ikke brændstof.");
                    return 0;
                }
            }

            // Udskriver bilens oplysninger
            public void PrintCarDetails()
            {
                Console.WriteLine("\n --- Biloplysninger ---");
                Console.WriteLine($"Mærke: {brand}");
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"Årgang: {year}");
                Console.WriteLine($"Gear: {gear}");
                Console.WriteLine($"Kilometertæller: {odometer} km");
                Console.WriteLine($"Brændstoftype: {fuelType}");
                Console.WriteLine($"Km per liter: {kmPerLiter}");
                Console.WriteLine($"Motorstatus: {(isEngineOn ? "Tændt " : "Slukket ")}");
            }
        }
    }
}