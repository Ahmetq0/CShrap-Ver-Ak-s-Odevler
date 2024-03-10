using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Digital_Operations
    {
        public static void Negative_and_Positive()
        {
            int number = Get_Number.Get_Number_1();

            if (number < 0)
            {
                Console.WriteLine("Bu sayı negatif olduğu için işlem yapılamaz");
            }

            else
            {
                int sayac = 0;

                while (number > 0)
                {
                    number /= 10;
                    sayac++;
                }
                Console.WriteLine("Gridiğiniz sayı" + sayac + "basamaklıdır");
            }
        }
    }
}
