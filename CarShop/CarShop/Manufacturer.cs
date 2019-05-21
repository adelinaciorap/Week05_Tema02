namespace CarShop
{
    public class Manufacturer
    {
        public Manufacturer(string brandName)
        {
            this.Brand = brandName;
        }

        public string Brand { get; private set; }
    }

}

