using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var onLot = new CarLot();

            //TODO
            
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //var carBest = new Car();
            //carBest.Make = "Chevy";
            //carBest.Model = "Equinox";
            //carBest.Year = 2013;
            //carBest.IsDriveable = true;
            //carBest.EngineNoise = "hummmm";
            //carBest.HonkNoise = "honkbeep";
            //carBest.MakeEngineNoise();
            //carBest.MakeHonkNoise();

            //// Set the properties utilizing the 3 different ways we learned about, one way for each car
            //var newCar1 = new Car() { Make = "Honda", Model = "Fit", Year = 2017, IsDriveable = true, EngineNoise = "Prrrr", HonkNoise = "pip"};
            //newCar1.MakeEngineNoise();
            //newCar1.MakeHonkNoise();

            //var newCar2 = new Car(2020, "Toyota", "Camery", true, "vroom", "beeeeep");

            //onLot.Cars.Add(carBest);
            //onLot.Cars.Add(newCar1);
            //onLot.Cars.Add(newCar2);

            //foreach(var vehicles in onLot.Cars)
            //{
            //    Console.WriteLine($"{vehicles.Year}, {vehicles.Make}, {vehicles.Model}");
            //}

            var car7 = new Car();
            Console.WriteLine(CarLot.NumberOfCars);
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
