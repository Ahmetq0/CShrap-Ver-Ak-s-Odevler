using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Digital_Process
    {
        public static void Number_Control()
        {


            int i = 0;

            while (true)
            {

                int number1 = Selectad_Number.Get_Number();

                if (i == number1)
                {
                    Console.WriteLine("Girdiğiniz Sayı:" + number1);
                    break;
                }

                else if (i != number1)
                {
                    Console.WriteLine("Girdiğiniz Sayı:" + number1 * 10);
                    continue;
                }







            }
        }
    }
}

