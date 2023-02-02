using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lib_light_bulb
{
    public class LampadinaRegolabile :Lampadina
    {
        int _pot;
        public int potenza
        {
            get
            {
                return _pot;
            }
            set
            {
                _pot = value >= 100 ? 100 : (value < 1 ? 1 : value);
            }
        }

        public void SetPower(int n)
        {
            if (acceso_spento)
            {
                pot = n;
            }
        }
        public override string ToString()
        {
            string support;
            for (int i = 0; i < length; i++)
            {

            }
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
