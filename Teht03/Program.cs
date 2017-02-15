using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets create and destroy a warehouse with stuff and destroy it!");
            Varasto varasto1 = new Varasto(new Tavara("Hieno patsas"));
            varasto1 = null;
            
            
      
        }
    }
}