using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev17
{
    internal class Process
    {
        public static void For_Alfabe()
        {
            char değer = (char)65;

            for (char alfabe = değer ; alfabe < 90;  alfabe++ )
            {
                Console.WriteLine(alfabe);
            }
        }
    }
}
