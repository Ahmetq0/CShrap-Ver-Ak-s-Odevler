using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev15
{
    internal class Process
    {
        public static void For_print()
        {
            for (int i = 6; i <=12;i++)
            {
                Console.WriteLine(i);
            }
            
        }

        public static void While_Print()
        {
            int i = 5;

            while (i < 12) 
            {
                i++;
                Console.WriteLine(i);
            }
            
        }

        public static void Do_While_Print()
        {
            int i = 5;

            do
            {
                i++;
                Console.WriteLine(i);
            }
            while (i < 12);
            
        }
    }
}
