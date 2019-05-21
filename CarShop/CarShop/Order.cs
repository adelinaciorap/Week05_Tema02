
using System;
using System.Collections.Generic;
using System.Text;
namespace CarShop
{
    public class Order
    {
        public Order(Car car)
        {
            this.Car = car;
            this.Price = Price;
            Random test= new Random();
            this.Delivery = test.Next(7, 15);

        
          }

        public Car Car { get; private set; }
        public double Price { get; private set; }

        public int Delivery { get; private set; }
    }
}

