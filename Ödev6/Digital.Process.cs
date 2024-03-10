using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ödev6
{
    internal class Digital
    { 
        public static void Number_Count()
        {
            int toplam = 0;
            

            int number1 = Selectde_Number.Get_Number_1();
            int number2 = Selectde_Number.Get_Number_2();

            while (number1 < number2)
            {
                Console.WriteLine(number1);
                number1+= 1;

            }



        }

    }
}
