using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torsos;
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

        public AstronautTorso Torso { get; set; }
        public AstronautLegs Legs { get; set; }
        public AstronautHead Head { get; set; }
        

        //Created Constructor ctor tab tab
        public Astronaut(string name, string job, AstronautHead head, AstronautTorso torso, AstronautLegs legs)
        {
            Name = name;
            Job = job;
            Head = head;
            Torso = torso;
            Legs = legs;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob(int stepsToWalk)
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties...");
            Legs.Walk(stepsToWalk);
            Head.EatPie("Cherry");
            Torso.Flex();
            Legs.Walk(stepsToWalk);
        }
    }
}
