using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    throw new ApplicationException(string.Format("animal '{0}' cannot be created", animal));
            }
        }
    }
}
