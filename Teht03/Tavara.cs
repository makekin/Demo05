using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Tavara
    {

            public string Name { get; set; }

            public Tavara(string name)
            {
                Name = name;
            }

            ~Tavara()
            {
                Console.WriteLine("Stuff called " + Name + " was destroyed");
            }
        }
    }

