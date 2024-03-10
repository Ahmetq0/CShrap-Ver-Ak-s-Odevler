using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev4
{
    internal class Digital_Process
    {
        public static int Get_Number()
        {
            Console.WriteLine("Sayıyı giriniz");
            return Convert.ToInt32(Console.ReadLine());



        }

        public static string Negative()
        {
            int number = Get_Number();

            if (number < 0)
            {
                Console.WriteLine("Girdiğiniz sayı negatiftir");
                
            }
            return Negative();
        }

        public static string Positive() 
        {
            int number = Get_Number();

            if (number > 0) 
            {
                Console.WriteLine("Girdiğiniz sayı pozitiftir");
            }
            return Positive();
        }


    }
}
