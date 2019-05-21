using System;
using System.Collections.Generic;

namespace CarShop
{
    public  class Customer: ICustomer
    {
        public Customer(string name)
        {
            this.Name = name;
       
         }

        public string Name { get; private set; }
        public Order ordToCheck { get; private set; }
        private int index = 0;
        private bool visit = false;

        public void Visit(Store StoreName)
        {
            Console.WriteLine($"You are now visiting the {StoreName.Name}");

            StoreName.ShowCars();

            Console.Write("Choose a car by it's index: ");
            index = Convert.ToInt32(Console.ReadLine());
        }

            public void Order(Store StoreName)
            {
                if (visit == false)
                {
                    List<Car> cars = StoreName.ViewCarList();
                    Order Ord = new Order(cars[index]);
                    Console.WriteLine();
                    Console.WriteLine($"You just ordered: {cars[index].Brand} - {cars[index].Model} - {cars[index].Year} - {cars[index].Price} euro.");
                    Console.WriteLine($"The order will arrive in {Ord.Delivery} days.");
                    Console.WriteLine();
                    ordToCheck = Ord;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You already made an order from another store.\nDo you agree on changing it?");
                    string check = Console.ReadLine();
                    if (check.ToLower() == "yes")
                    {
                        List<Car> cars = StoreName.ViewCarList();
                        Order Ord = new Order(cars[index]);
                        Console.WriteLine("The other order was canceled.");
                        Console.WriteLine();
                        Console.WriteLine($"You just ordered: {cars[index].Brand} - {cars[index].Model} - {cars[index].Year} - {cars[index].Price} euro.");
                        Console.WriteLine($"The order will arrive in {Ord.Delivery} days.");
                        Console.WriteLine();
                        ordToCheck = Ord;
                    }

                }
                visit = true;
            }
        }

}

