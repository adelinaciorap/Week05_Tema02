using System.Collections.Generic;

namespace CarShop
{
    interface IStore
    {
        List<Car> ViewCarList();
        void ShowCars();
    }

}

