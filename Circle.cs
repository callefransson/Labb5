using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    internal class Circle // Skapar en ny klass Circle som lagrar metoderna för att räkna ut arean, omkretsen och volymen
    {  
            //Propertyn
            private int _radius { get; set; }
            public Circle(int radius) // Konstruktorn för klassen Circle som tar ett argument vilket är en int med namnet radius.
            {
                _radius = radius;
            }
        public double GetArea() // Metoden för att räkna ut arean på cirkeln
            {
                return _radius * _radius * Math.PI; // Retunerar arean
            }
            public double GetCircumference() // Metoden för att räkna ut omkretsen på cirkeln
            {
                return _radius * Math.PI * 2; // Retunerar omkretsen
            }
            public double GetVolume() // Metoden för att räkna ut sfären
            {
                double advanced = Math.Pow(_radius, 3); //Math.Pow används för att använda ekvationen upphöjt. Så _radius upphöjt till 3
                return (4 / 3) * Math.PI * advanced; // Retunerar sfären
            }
        }
    }

