using AbstractClassesDemo;
using System;
namespace ConsoleUI 
{
    class Progrom
    {
        static void Main(string[] args)
        {
            #region vehicles

            var vehicles = new List<Vehicle>();
             
            var car1 = new Car()
            { 
                HasTrunk = true,
                Year = "2000",
                Make = "Ford",
                Model= "F-150"
            };
            var motorcycle1 = new Motorcycle()
            { 
                HasSidecart = true,
                Year = "2001",
                Make = "Kawasaki",
                Model = "Ninja"
            };
            Vehicle vehicle1 = new Car() 
            { 
                Make = "Ford", 
                Year = "2014",
                Model = "Focus"
            };
            Vehicle vehicle2 = new Motorcycle()
            { 
                Year = "2014",
                Make = "Harley" ,
                Model = "Davidson"
            };
            
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var Vehicle in vehicles)
            {
                Console.WriteLine($"Year: {Vehicle.Year} \nMake: {Vehicle.Make} \nModel: {Vehicle.Model}");
               
                Vehicle.DriveAbstract();
                Vehicle.DriveVirtual();
                Console.WriteLine(" ");
               
            }






            #endregion
        }
    }
}
