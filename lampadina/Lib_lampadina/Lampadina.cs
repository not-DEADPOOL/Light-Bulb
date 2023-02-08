using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lib_light_bulb
{
    public class Lampadina
    {
        public bool acceso_spento;
        int _pot;
        public int potenza
        {
            get { return _pot; }
            set { _pot = value >= 100 ? 100 : (value < 1 ? 1 : value); }
        }
        public Lampadina(bool a_s, int pot)
        {
            acceso_spento = a_s;
            potenza = pot;
        }
        public Lampadina() : this(false, 60) { }
        public void Accendi()
        {
            acceso_spento = true;
        }
        public void Spegni()
        {
            acceso_spento = false;
        }

        public override string ToString()
        {
            Animation.Loading();
            return !acceso_spento ? @"    ..---.." + "\n" + @"   /       \" + "\n" + @"  |         |" + "\n" + @"  :         ;"
                    + "\n" + @"   \  \~/  /" + "\n" + @"    `, Y ,'" + "\n" + @"     |_|_|" + "\n"
                    + @"     |===|" + "\n" + @"     |===|" + "\n" + @"      \_/" + "\n" : @"              |" + "\n" + @"       \   ..---..   /" + "\n" +
                    @"          /       \" + "\n" + @"    __   |         |   __" + "\n" + @"         :         ;" + "\n" + @"          \  \~/  /" + "\n" + @"       /   `, Y ,'   \" + "\n" + @"            |_|_|" + "\n" + @"            |===|" +
                    "\n" + @"            |===|" + "\n" + @"             \_/" + "\n";
        }
        //              |
        //       \   ..---..   /
        //          /       \
        //    __   |         |   __
        //         :         ;
        //          \  \~/  /
        //       /   `, Y ,'   \
        //            |_|_|
        //            |===|
        //            |===|
        //             \_/
    }
}
