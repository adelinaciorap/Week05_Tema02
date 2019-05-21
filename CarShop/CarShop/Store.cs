using System;
using System.Collections.Generic;

namespace CarShop
{
    public class Store : IStore
    {
        public Store(string name, string city)
        {
            this.Name = name;
            this.City = city;
            Cars = new List<Car>();

        }

        public string Name { get; private set; }
        public string City { get; private set; }
        private List<Car> Cars { get; set; }

        public List<Car> ViewCarList()
        {
            return Cars;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

            public void ShowCars()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine($"{car.Brand} - {car.Model} - { car.Year} - {car.Price} Euro.");
            }
            Console.WriteLine();
        }



    }

}

