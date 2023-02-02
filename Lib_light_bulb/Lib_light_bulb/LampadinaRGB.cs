using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lib_light_bulb
{
    public class LampadinaRGB:LampadinaRegolabile
    {
        public override string ToString()
        {
            return @"  ..---.." + "\n" + @" /       \" + "\n" + @"|         |" + "\n" + @":         ;"
                    + "\n" + @" \  \~/  /" + "\n" + @"  `, Y ,'" + "\n" + @"   |_|_|" + "\n"
                    + @"   |===|" + "\n" + @"   |===|" + "\n" + @"    \_/" + "\n";
        }

        //private static String RGBConverter(System.Drawing.Color c)
        //{
        //    return "RGB(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
        //}
    }
}
