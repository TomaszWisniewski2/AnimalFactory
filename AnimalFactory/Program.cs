using System;

namespace AnimalFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new ConcreteAnimal();
            Interface1 krowa = animal.GetAnimal("Krowa");
            krowa.nogi(4);

            Interface1 ptak = animal.GetAnimal("Ptak");
            ptak.nogi(2);
        }
    }
}
