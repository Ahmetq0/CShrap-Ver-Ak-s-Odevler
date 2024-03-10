using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ödev10
{
    internal class Process
    {
        public static void Digital_Proces()
        {
            int i = 0;
            int a = 500;

            while (i <= 490) {

                if (15 % 3 == 0 && 15 % 5 == 0)
                {

                    int total = i+=15;
                    Console.WriteLine(total);
                    
                }
            }
        }
       
    }
}
