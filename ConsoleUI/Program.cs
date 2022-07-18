using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            // setting properties using dot notation
            var car1 = new Car();
            car1.Make = "Tesla";
            car1.Model = "Model S";
            car1.Year = "2021";
            car1.HasTrunk = true;

            //setting properties using object initializer syntax
            var motorcycle1 = new Motorcycle()
            { Make = "BMW", Model= "7873X", Year = "2023", HasSideCart = true };

            Vehicle car2 = new Car()
            { Make = "Toyota", Model = "Camry", Year = "2022", HasTrunk = true};

            Vehicle motorcycle2 = new Motorcycle()
            { Make = "Ninja", Model = "Zoom", Year = "2019", HasSideCart = true};


            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motorcycle1);
            vehicles.Add(motorcycle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.Year);

                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
            }



            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}
