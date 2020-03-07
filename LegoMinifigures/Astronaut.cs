using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    enum Location
    {
        Earth,
        Space,
        SpaceStation
    }

    class Astronaut
    {
        //Created Properties

        //Public Property
        public Location Location { get; set; }

        //Expression Bodied Property (always read-only)
        public bool SuitedUp => Name == "Space Person";

        //Read-Only Property
        public string Name { get; }

        //Public Property with a private setter
        public string Job { get; private set; }

        public int OxygenLevel { private get; set; }
        

        //Created Constructor ctor tab tab
        public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob()
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties...");
        }
    }
}
