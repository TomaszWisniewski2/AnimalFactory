using System;


namespace AnimalFactory
{
    class Ptak : Interface1
    {
        public void nogi(int ilość)
        {
            Console.WriteLine("Ptak ma  : " +ilość+ " nogi");
        }
    }
}
