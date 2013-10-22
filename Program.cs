using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCarnetCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Carnet carnet = new Carnet();
            carnet.Menu();
            Console.ReadLine();
        }

    }
}