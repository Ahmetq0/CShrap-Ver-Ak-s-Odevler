using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21
{
    internal class prcess
    {
        public static void Operation()
        {
            int i = 4;
            int a = 52;

            while (a >= i)
            {
                int total = a-=3;
                Console.WriteLine(total);
            }
        }
    }
}
