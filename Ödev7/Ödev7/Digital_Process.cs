using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev7
{
    internal class Digital_Process
    {
        public static void Calculator_Sum()
        {
            int i = 0;

            while (true)
            {

                int number1 = Get_Number.Get_Number_1();
                int number2 = Get_Number.Get_Number_2();



                if (number1 == i && number2 == 0)
                {
                    Console.WriteLine("Sonuç:" + number1);
                    break;

                }

                else if (number1 != 0 && number2 != 0)
                {

                    int calculator_opartion = number1 + number2;

                    Console.WriteLine("Sonuç:" + calculator_opartion);
                }


                
            }
            

        }
    }

}

