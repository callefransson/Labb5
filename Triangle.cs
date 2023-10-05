using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    internal class Triangle // Skapar en ny klass för att räkna ut arean på en triangel
    {
        public double GetTriangleArea() // Metoden för uträkningen
        {
            double lenght;
            double height;
            Console.WriteLine("Nu ska vi räkna ut arean på en triangel");
            while (true) // Loopen kör tills användaren skriver in heltal
            {
                Console.WriteLine("Vänligen skriv in basen på triangeln");
                if (double.TryParse(Console.ReadLine(), out lenght)) //Försöker omvanlda från en string till en double som lagrar resultatet i variabeln lenght
                {
                    break; // Om inmatningen är giltig så avslutas loopen
                }
                else // Om inmatningen inte är ett heltal
                {
                    Console.WriteLine("Vänligen skriv in endast heltal");
                }
            }
            while (true)
            {
                Console.WriteLine("Vändligen skriv in höjden på triangeln");
                if (double.TryParse(Console.ReadLine(), out height))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Vänligen skriv in endast heltal");
                }

            }
            double triangleArea = lenght * height / 2; //Uträkningen för arean
            return triangleArea; // Retunerar arean på triangeln
        }
    }
}
