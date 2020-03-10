using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Heads
{
    enum LegoColor
    {
        Yellow,
        Red,
        Green,
        White,
        Grey,
        Blue,
        Black,
        Orange
    }
    class AstronautHead
    {
        public bool Helmeted { get; set; }
        public string FacialExpression { get; set; }
        public LegoColor Color { get; set; }
        public LegoColor EyeColor { get; set; }

        public void Talk()
        {
            Console.WriteLine($"The {FacialExpression} astronaut says 'Tell my wife I love her very much.'");
        }

        public void EatPie(string typeOfPie)
        {
            if (typeOfPie == "apple")
                Console.WriteLine("MMM.. Pie.");
            else
                Console.WriteLine("This is not pie.");
        }
    }
}
