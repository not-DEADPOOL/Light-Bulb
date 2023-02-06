using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_light_bulb;
namespace lampadina
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampadina l = new Lampadina();
            l.Spegni();
            Console.WriteLine(l);
            Console.ReadKey(true);
        }
    }
}
