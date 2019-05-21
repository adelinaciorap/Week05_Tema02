using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Program
    {

        static void Main(string[] args)
        {
            Store Ford= new Store("FordStore", "Iasi");
            Ford.AddCar(new Car("Ford", "Focus", 2015, 15000));
            Ford.AddCar(new Car("Ford", "Focus", 2018, 25000));

            Store Skoda = new Store("Skoda Store", "Vaslui");
            Ford.AddCar(new Car("Skoda", "Fabia", 2015, 14000));
            Ford.AddCar(new Car("Skoda", "Fabia", 2017, 19000));



            Customer p1 = new Customer("Alex");
            p1.Visit(Ford);
            p1.Order(Ford);

            p1.Visit(Skoda);
            p1.Order(Skoda);
            
            

            Console.ReadKey();
        }

    }

}

