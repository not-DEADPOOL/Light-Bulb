using System;
using System.Collections.Generic;
using System.Text;
using Lib_light_bulb;

namespace Lib_light_bulb
{
    public class Ledstrip
    {
        public List<Lampadina> lampadine { get; private set; }
        public Ledstrip()
        {
            List<Lampadina> lampadine = new List<Lampadina>();
        }
        public void AccendiNum(int n)
        {
            lampadine[n - 1].Accendi();
        }
        
        public void Attacca(Lampadina? l)
        {
            lampadine.Add(l);
        }
        public void Stacca(Lampadina? l)
        {
            if (lampadine.Contains(l))
                lampadine.Remove(l);
        }
        public int Taglia(int partenza)
        {
            partenza = partenza>=lampadine.Count ? lampadine.Count: partenza;
            int counter=0;
            for (int i = partenza; i < lampadine.Count; i++)
            {
                lampadine.RemoveAt(i);
                counter++;
            }
            return counter;
        }
    }
}
