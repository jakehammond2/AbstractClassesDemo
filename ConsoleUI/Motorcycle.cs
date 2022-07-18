using System;
namespace ConsoleUI
{
    public class Motorcycle: Vehicle 
    {
        public Motorcycle()
        {
        }

        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("driving motorcycle abstractly");
        }


        public override void DriveVirtual()
        {
            Console.WriteLine("Driving a motorcycle virtually");
        }
    }
}

