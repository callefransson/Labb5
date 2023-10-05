using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    internal class Circle // Skapar en ny klass Circle som lagrar metoderna för att räkna ut arean, omkretsen och volymen
    {  
            // De egenskaperna som används i klassen
            public double _pi = Math.PI;
            public int _radius;
            public Circle(int radius) // Konstruktorn för klassen Circle som tar ett argument vilket är en int med namnet radius.
            {
                _radius = radius;
            }


            public double GetArea() // Metoden för att räkna ut arean på cirkeln
            {
                double area = _radius * _radius * _pi;
                return area; // Retunerar arean
            }

            public double GetCircumference() // Metoden för att räkna ut omkretsen på cirkeln
            {
                double circumference = _radius * _pi * 2;
                return circumference; // Retunerar omkretsen
            }
            public double GetVolume() // Metoden för att räkna ut sfären
            {
                double advanced = Math.Pow(_radius, 3); //Math.Pow används för att använda ekvationen upphöjt. Så _radius upphöjt till 3
                double sphere = (4 / 3) * _pi * advanced;
                return sphere; // Retunerar sfären
            }

        }
    }

