using System;
using System.Collections.Generic;
using ConsoleUI;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }

        public string Year { get; set; } = "2020";
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Accord";

        public abstract void DriveAbstract();
        

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Base Implementation for driving virtual.");
        }

        
       

    }
}

