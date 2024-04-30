using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            CarLot carLot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.Year = 2022;
            car1.EngineNoise = "purr";
            car1.HonkNoise = "beep";
            car1.IsDriveable = true;
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            carLot.Cars.Add(car1);
            Console.WriteLine("");


            Car car2 = new Car()
            {
                Make = "Chevy",
                Model = "Nova",
                Year = 1980,
                IsDriveable = false,
                EngineNoise = "klunk",
                HonkNoise = "boop"
            };
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            carLot.Cars.Add(car2);
            Console.WriteLine("");


            Car car3 = new Car() { Make = "Ford", Model = "Mustang", Year = 1967, IsDriveable = true, EngineNoise = "Vroom", HonkNoise = "honk" };
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            carLot.Cars.Add(car3);
            Console.WriteLine("");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (Car car in carLot.Cars)
            {
                car.DescribeCar();
            }
        }
    }
}
