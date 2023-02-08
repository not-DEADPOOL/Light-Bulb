using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;


namespace Lib_light_bulb
{
    public class LampadinaRGB : LampadinaRegolabile
    {
        int _r,_g,_b;
        int R { get { return _r; } set { _r = value > 255 ? 255 : (value < 0 ? 0 : value); } }
        int G { get { return _g; } set { _g = value > 255 ? 255 : (value < 0 ? 0 : value); } }
        int B { get { return _b; } set { _b = value > 255 ? 255 : (value < 0 ? 0 : value); } }
        public LampadinaRGB(int R, int G, int B, int potenza)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.potenza = potenza;
        }
        public override string ToString()
        {
            Animation.Loading();
            Console.ForegroundColor = ClosestConsoleColor((byte)R, (byte)G, (byte)B);
            Console.Write(Getstampa());
            Console.ForegroundColor = ConsoleColor.White;
            return Getstampa2();
        }
        static ConsoleColor ClosestConsoleColor(byte r, byte g, byte b)
        {
            ConsoleColor ret = 0;
            double rr = r, gg = g, bb = b, delta = double.MaxValue;

            foreach (ConsoleColor cc in Enum.GetValues(typeof(ConsoleColor)))
            {
                var n = Enum.GetName(typeof(ConsoleColor), cc);
                var c = Color.FromName(n == "DarkYellow" ? "Orange" : n);
                var t = Math.Pow(c.R - rr, 2.0) + Math.Pow(c.G - gg, 2.0) + Math.Pow(c.B - bb, 2.0);
                if (t == 0.0)
                    return cc;
                if (t < delta)
                {
                    delta = t;
                    ret = cc;
                }
            }
            return ret;
        }
    }
}
