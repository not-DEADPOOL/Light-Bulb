using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lib_light_bulb
{
    internal class Animation
    {
        public static void Loading()
        {
            Console.CursorVisible = false;
            string[] frames = { "<", "^", ">", "v" };
            for (int i = 0; i < 5; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.SetCursorPosition(8, 5);
                    Console.WriteLine("\t" + frame);
                    Thread.Sleep(50);
                }
            }
            Console.Clear();
            Console.CursorVisible = true;
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
