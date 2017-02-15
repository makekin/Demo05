using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Varasto
    {

        private Tavara romu1;

        public Varasto()
        {
        }

        public Varasto(Tavara romu1)
        {
            this.romu1 = romu1;
        }

        ~Varasto()
        {
            Console.WriteLine("Varasto was destroyed");
        }

        public void UseComputer()
        {
            Console.WriteLine("Warehouse eats stuff " + romu1.Name);
        }

    }
}

