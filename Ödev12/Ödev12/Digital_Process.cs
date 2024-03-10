using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev12
{
    internal class Digital_Process
    {
        public static void Divide_Opration()
        {
           

                while (true)
                {
                    int number1 = Selected_Number.Get_Number_1();
                    int number2 = Selected_Number.Get_Number_2();

                    if (number1 == 0 && number2 == 0)
                    {
                        Console.WriteLine("O Girilemez");
                        break;
                    }

                    else if (number1 != 0 && number2 != 0)
                    {
                        int divide_sum = number1 / number2;

                        Console.WriteLine("Bölme işlemi sonucu:" + divide_sum);

                        int divide_mod_sum = number2 % number1;

                        Console.WriteLine("Bölmeden Kalan:" + divide_mod_sum);
                        continue;
                        
                    }
                }
            }
        }

    }





