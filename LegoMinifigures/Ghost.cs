using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    //implicity internal class named Ghost
    class Ghost
    {
        //created Properties
        public bool Friendly { get; set; }
        public bool IsVisible { get; set; }
        public string Name { get; set; }

        //Public Property w/ a private setter
        public string HauntingLocation { get; private set; }

        //Read-Only Property
        public DateTime DeathDay { get; }

        //created constructor
        public Ghost(string name, DateTime deathDay)
        {
            Name = name;
            DeathDay = deathDay;
        }

        public void Haunt(string hauntingLocation)
        {
            HauntingLocation = hauntingLocation;
            Console.WriteLine($"{Name} has moved into {HauntingLocation}");
        }

        public void Spook()
        {
            if (string.IsNullOrEmpty(HauntingLocation)) return;
           
            Console.WriteLine($"{Name} does a spook at {HauntingLocation}");
        }
    }
}
