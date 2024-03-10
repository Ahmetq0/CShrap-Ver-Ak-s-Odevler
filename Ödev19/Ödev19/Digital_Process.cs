using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ödev19
{
    internal class Digital_Process
    {
        public static void Extraction_Oprations()
        {
            
            int number1 = Get_Number.Get_Number_1();
            int number2 = Get_Number.Get_Number_2();

            int number1 , number2 , sonuç = 0;


            for (int i = 0; i < number2; i++)
            {
                sonuç += number1;
            }
        }
    }
}
