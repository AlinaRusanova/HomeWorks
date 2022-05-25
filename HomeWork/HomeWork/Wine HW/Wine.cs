using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine
{
    public class Wine
    {
        public WineColor WineColor { get; set; }
        public WineType WineType { get; set; }
        public int WineYearOfProduction { get; set; }
        public int WineStrength { get; set; }

        public Wine(WineColor wineColor, WineType wineType, int wineYearOfProduction, int wineStrength)
        {
            WineColor = wineColor;
            WineType = wineType;
            WineYearOfProduction = wineYearOfProduction;
            WineStrength = wineStrength;
        }



        public void Appear()
        {
            Console.WriteLine($"This wine was produced in {WineYearOfProduction} year, it  is {WineType}, has {WineColor} color and {WineStrength} % Strength ");
             
        }

    }
}





// добавить ид
// начинаем склад