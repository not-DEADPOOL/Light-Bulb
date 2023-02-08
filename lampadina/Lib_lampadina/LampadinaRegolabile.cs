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
        public void SetPower(int n) { if (acceso_spento) potenza = n; }
        protected string Getstampa()
        {
            string support = "", stampa = "";
            int c = potenza / 10;
            for (int i = 0; i < c; i++)
                support += ".";
            string[] llampa = {@"       .......::::::.......", @"    .......:::======:::.......",
                                @"  .......::===========::........", @" ......::===####@@####===::......",@"......::===####@@@@####===::......",
                                @".....::===####@@@@@@####===::.....",@".....::===#####@@@@#####===::.....",@" .....::===#####@@#####===::.....",
                                @"  .....::====########====::.....",@"   .....::=====####=====::.....",@"     ....::============::....",
                                @"       ...::==========::...",@"         ..::========::.."};
            for (int i = 0; i < llampa.Length; i++)
            {
                for (int k = 0; k < llampa[i].Length; k++)
                {
                    if (llampa[i][k] == '.')
                    {
                        llampa[i] = llampa[i].Insert(k, support);
                        break;
                    }
                }
                for (int k = llampa[i].Length - 1; k > 0; k--)
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
            return stampa;

        }
        protected string Getstampa2() {
            string support2 = "";
            for (int i = 0; i < potenza/10; i++)
                support2 += " ";
            return support2 + @"           |__________|" + "\n" + support2 + @"           <__________>" + "\n" + support2 + @"           <__________>" + "\n" + support2 + @"           <__________>" + "\n" + support2 + @"            \________/" + "\n";
        }
        public override string ToString()
        {
            Animation.Loading();
            return Getstampa()+Getstampa2();
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
