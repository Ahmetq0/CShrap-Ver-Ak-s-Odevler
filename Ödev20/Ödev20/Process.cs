using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev20
{
    internal class Process
    {
        public static void Yes_Asal_and_No_Asal()
        {
            int kontrol = 0;

            int number = Get_Number.Number();

            int i = 2;
            while (i < number)
            {
                if (number % i == 0)

                    kontrol++;

                i++;
            }   

                if (kontrol != 0) 
                {
                    Console.WriteLine("Girdiğiniz sayı bir asal sayı değildir");
                }

                else
                {
                    Console.WriteLine("Girdiğiniz sayı asal sayıdır");
                }
                Console.ReadKey();
            }
        }
    }

