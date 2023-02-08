using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Lib_light_bulb;

namespace lampadina
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampadina l = new Lampadina();
            l.Accendi();
            Console.WriteLine(l);
            Thread.Sleep(1000);
            Console.Clear();
            LampadinaRegolabile lr = new LampadinaRegolabile();
            lr.Accendi();
            lr.SetPower(150);
            Console.WriteLine(lr);
            Thread.Sleep(1000);
            Console.Clear();
            LampadinaRGB lrgb = new LampadinaRGB(698, 0, 2354, 50);
            lrgb.Accendi();
            Console.WriteLine(lrgb);
            Thread.Sleep(1000);
            Console.Clear();
            Ledstrip ls = new Ledstrip();
            ls.Attacca(l);
            ls.Attacca(lr);
            ls.lampadine[1].Accendi();
            Console.WriteLine(ls.lampadine[1]);
            Console.ReadKey();
        }
    }
}
