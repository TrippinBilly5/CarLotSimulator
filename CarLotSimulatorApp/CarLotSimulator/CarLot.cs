using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public static int numberOfCars = 0;
        public List<Car> Cars {  get; set; }
        public CarLot() { 
            Cars = new List<Car>();
        }
    }
}
