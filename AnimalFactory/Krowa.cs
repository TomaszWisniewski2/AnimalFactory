using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    
    class Krowa : Interface1
    {
        public void nogi(int ilość)
        {
            Console.WriteLine("Krowa ma  : "+ ilość  + " nogi");
        }
    }
}

