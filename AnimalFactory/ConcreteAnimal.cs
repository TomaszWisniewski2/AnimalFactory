using System;


namespace AnimalFactory
{
    class ConcreteAnimal : Animal
    {
        public override Interface1 GetAnimal(string animal)
        {
            switch (animal)
            {
                case "Krowa":
                    return new Krowa();
                case "Ptak":
                    return new Ptak();
                default:
                    throw new ApplicationException(string.Format("Animal '{0}' cannot be created", animal));
            }
        }
    }
}
