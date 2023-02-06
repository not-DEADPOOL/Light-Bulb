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
            LampadinaRegolabile ll = new LampadinaRegolabile();
            ll.Accendi();
            ll.SetPower(100);
            Console.WriteLine(ll);
            Console.ReadKey();
        }
    }
}
