using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev9
{
    internal class Process
    {
        public static int Number()
        {
            Console.WriteLine("Sayı Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int Number2()
        {
            Console.WriteLine("Kaç Basamaklı Olacağını Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int Selected_Process()
        {
            int number1 = Number();
            int number2 = Number2();

            int i = 0;
            while (i < number2) 
            {
                Console.WriteLine("Girilen sayı:"+number1);
                i++;
            }
            return number1;



        }
    }
}
