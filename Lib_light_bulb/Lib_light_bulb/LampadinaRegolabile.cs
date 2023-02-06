using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lib_light_bulb
{
    public class LampadinaRegolabile : Lampadina
    {
        int _pot;
        public int potenza
        {
            get{return _pot;}
            set{_pot = value >= 100 ? 100 : (value < 1 ? 1 : value);}
        }

        public void SetPower(int n){if (acceso_spento)pot = n;}
        protected string Getstampa()
        {
            string support = "", stampa = "";
            int c = potenza / 10;
            for (int i = 0; i < c; i++)
            {
                support += ".";
            }
            string[] llampa = {@"       .......::::::.......", @"    .......:::======:::.......",
                                @"  .......::===========::........", @" ......::===####@@####===::......",@"......::===####@@@@####===::......",
                                @".....::===####@@@@@@####===::.....",@".....::===#####@@@@#####===::.....",@" .....::===#####@@#####===::.....",
                                @"  .....::====########====::.....",@"   .....::=====####=====::.....",@"     ....::============::....",
                                @"       ...::==========::...",@"         ..::========::.."};
            for (int i = 0; i < llampa.Length; i++)
            {
                for (int k = 0; k < llampa[i].Length; k++)
                {
                    if (llampa[i][k+1]=='.')
                    {
                        llampa[i] = llampa[i].Insert(k, support);
                        break;
                    }
                }
                for (int k = llampa[i].Length-1; k > 0; k--)
                {
                    if (llampa[i][k - 1] == '.')
                    {
                        llampa[i] = llampa[i].Insert(k, support);
                        break;
                    }
                }
            }
            for (int i = 0; i < llampa.Length; i++)
            {
                stampa += llampa[i] + "\n"; 
            }
            return stampa + @"           |__________|" + "\n" + @"           <__________>" + "\n" + @"           <__________>" + "\n" + @"           <__________>" + "\n" + @"            \________/" + "\n";

        }
        public override string ToString()
        {
            return Getstampa();
        }
        //            ..........
        //       .......::::::.......
        //    .......:::======:::.......
        //  .......::===========::........
        // ......::===####@@####===::......
        //......::===####@@@@####===::......
        //.....::===####@@@@@@####===::.....
        //.....::===#####@@@@#####===::.....
        // .....::===#####@@#####===::.....
        //  .....::====########====::.....
        //   .....::=====####=====::.....
        //     ....::============::....
        //       ...::==========::...
        //         ..::========::..
        //           |__________|
        //           <__________>
        //           <__________>
        //           <__________>
        //            \________/
        
    }
}
