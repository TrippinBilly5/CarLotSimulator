using System;

namespace CarLotSimulator
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public Car()
        {
            CarLot.numberOfCars++;
            Console.WriteLine($"Number of cars in CarLot: {CarLot.numberOfCars}");
        }
        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"{this.Model} Engine Noise = {noise}");
        }
        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine($"{this.Model} Honk Noise = {noise}");
        }
        public void DescribeCar()
        {
            Console.WriteLine($"Car is a {this.Year} {this.Make} {this.Model}.  Is it driveable? --> {this.IsDriveable}");
        }
    }
}
