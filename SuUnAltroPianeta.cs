using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto! Quanti anni hai?");
            int Years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su quale pianeta ti interesserebbe trasferirti? Scegli tra:");
            Console.WriteLine(" 0: Mercurio" + "\n 1: Venere" + "\n 2: Marte" + "\n 3: Giove" + "\n 4: Saturno" + "\n 5 Urano" + "\n 6: Nettuno" + "\n 7: Plutone");

            int Choice = Convert.ToInt32(Console.ReadLine());
            double AgeOnPlanet = 0.0;
            int Months = 0;

            if(Choice >= 0 && Choice <= 7)
            {
                AgeOnPlanet = CalculateAge(Years, Choice);
                Months = CalculateMonths(AgeOnPlanet);

                AgeOnPlanet = Math.Truncate(AgeOnPlanet);
                string ChoosenPlanet = DeclarePlanet(Choice);

                Console.WriteLine("Su " + ChoosenPlanet + " avresti " + AgeOnPlanet + " anni e "+Months+" mesi\n");
            }
            else
            {
                Console.WriteLine("Numero di pianeta non valido, ritenta bene e ti sara' dato");
            }

        }

        public static string DeclarePlanet(int Planet)
        {
            string ChoosenPlanet = "";

            switch(Planet)
            {
                case 0:
                    ChoosenPlanet = "Mercurio";
                    break;
                case 1:
                    ChoosenPlanet = "Venere";
                    break;
                case 2:
                    ChoosenPlanet = "Marte";
                    break;
                case 3:
                    ChoosenPlanet = "Giove";
                    break;
                case 4:
                    ChoosenPlanet = "Saturno";
                    break;
                case 5:
                    ChoosenPlanet = "Urano";
                    break;
                case 6:
                    ChoosenPlanet = "Nettuno";
                    break;
                case 7:
                    ChoosenPlanet = "Plutone";
                    break;
                default:
                    ChoosenPlanet = "un pianeta non valido";
                    break;
            }

            return ChoosenPlanet;
        }

        static double CalculateAge(int EarthYears,int Planet)
        {
            double Age = 0.0;
            double Ratio = 0.0;
            double EarthRotation = 365.26;
            switch(Planet)
            {
                case 0://Mercury
                    Ratio = 87.97 / EarthRotation;
                    break;
                case 1://Venus
                    Ratio = 224.7 / EarthRotation;
                    break;
                case 2://Mars
                    Ratio = 1.88;
                    break;
                case 3://Jupiter
                    Ratio = 11.86;
                    break;
                case 4://Saturn
                    Ratio = 29.46;
                    break;
                case 5://Uranus
                    Ratio = 84.01;
                    break;
                case 6://Neptune
                    Ratio = 164.79;
                    break;
                case 7://Pluto
                    Ratio = 248.59;
                    break;
                default://Not a valid planet
                    Ratio = 1;
                    break;

            }

            Age = EarthYears / Ratio;

            return Age;
        }

        public static int CalculateMonths(double PlanetAge)
        {
            double IntPart = Math.Truncate(PlanetAge);

            double DecimalPart = PlanetAge - IntPart;

            double Ratio = 1.0 / 12.0;

            int Months = Convert.ToInt32(DecimalPart / Ratio);

            return Months;
        }
    }

}
