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
        public int pot;
        public Lampadina(bool a_s,int pot)
        {
            acceso_spento = a_s;
            this.pot = pot;
        }
        public Lampadina() :this(false,1){}
        public void Accendi() {
            acceso_spento = true;
        }
        public void Spegni(){
            acceso_spento = false;
        }
        
        public override string ToString()
        {
            return @"  ..---.." + "\n" + @" /       \"+ "\n" + @"|         |" + "\n" + @":         ;" 
                    + "\n" + @" \  \~/  /" + "\n" + @"  `, Y ,'" +"\n"+ @"   |_|_|" +"\n" 
                    + @"   |===|" + "\n" + @"   |===|" +"\n" + @"    \_/" +"\n";
        }

        //  ..---..
        // /       \
        //|         |
        //:         ;
        // \  \~/  /
        //  `, Y ,'
        //   |_|_|
        //   |===|
        //   |===|
        //    \_/
    }
}
