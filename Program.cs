// Carl Fransson .NET23
using System.Runtime.InteropServices;

namespace Labb5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle calcCircle1 = new Circle(5); // Skapar en ny instans av klassen Circle med värdet 5 och lagarar den nya instansen till variabeln calcCircle1
            Circle calcCircle2 = new Circle(6); // Skapar en ny instans av klassen Circle med värdet 6 och lagarar den nya instansen till variabeln calcCircle2

            //Här anropar vi innehållet från de metoderna som skrivits nedan och för in dom i variabeln innan
            Console.WriteLine("Arean på cirkeln med radie 5 är {0}", calcCircle1.GetArea());
            Console.WriteLine("Arean på cirkeln med radie 6 är: {0}", calcCircle2.GetArea());

            Console.WriteLine("Omkretsen på cirkeln är:{0} som har radie 5", calcCircle1.GetCircumference());
            Console.WriteLine("Omkretsen på cirkeln är:{0} som har radie 6", calcCircle2.GetCircumference());

            Console.WriteLine("Volymen på sfären är:{0} om radien är 5", calcCircle1.GetVolume());
            Console.WriteLine("Volymen på sfären är:{0} om radien är 6", calcCircle2.GetVolume());

            Triangle calcTriangle = new Triangle(); // Skapar en ny instans av klassen Triangle som lagras till variabeln calcTriangle

            Console.WriteLine();
            Console.WriteLine("Arean på triangeln som du skrev in är {0}",calcTriangle.GetTriangleArea()); //Anropar metoden GetTriangleArea från klassen Triangle
            Console.WriteLine("Tryck på valfri tangent för att stänga programmet");
            Console.ReadKey();
        }
    }

}