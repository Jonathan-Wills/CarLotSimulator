using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car ford = new Car();
            ford.Year = 2012;
            ford.Make = "Ford";
            ford.Model = "F150";
            ford.EngineNoise = "brummmm";
            ford.HonkNoise = "Doooot";
            ford.IsDriveable = true;

            ford.MakeEngineNoise();
            ford.MakeHonkNoise();

            Car chevy = new Car() { Year = 1972, Make = "Chevrolet", Model = "Impala", EngineNoise = "brumtumta", HonkNoise = "bom bom", IsDriveable = true };
            chevy.MakeEngineNoise();
            chevy.MakeHonkNoise();

            Car camry = new Car(2019, "Toyota", "Camry", "hmmm", "beeeeep", true);
            camry.MakeEngineNoise();
            camry.MakeHonkNoise();
           

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
