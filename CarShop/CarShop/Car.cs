namespace CarShop
{
    public class Car :Manufacturer
    {

        public Car(string brandName, string model, int year, double price) : base(brandName)
        {
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }


        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; private set; }

    }

}

