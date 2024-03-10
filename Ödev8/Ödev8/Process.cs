using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ödev8
{
    internal class Process
    {
        public static int Five_Process()
        {
            int number1 = Selected_Number.Get_Number_1();
            int number2 = Selected_Number.Get_Number_2();
            int number3 = Selected_Number.Get_Number_3();
            int number4 = Selected_Number.Get_Number_4();
            int number5 = Selected_Number.Get_Number_5();


            int calculator = number1 + number2 + number3 + number4 + number5;

            Console.WriteLine("Toplama İşlemi Sonucu:"+calculator);


            int arithmetic_mean = (number1 + number2 + number3 + number4 + number5)/5;

            Console.WriteLine("Aritmatik Ortalama:" + arithmetic_mean);


            Console.Write("1. sayıyı girin:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int enKucuk = sayi;
            int enBuyuk = sayi;

            int i = 1;
            while (i < 10)
            {
                Console.Write("{0}. sayıyı girin:", i + 1);
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi > enBuyuk)
                    enBuyuk = sayi;

                if (sayi < enKucuk)
                    enKucuk = sayi;

                i++;
            }

            Console.WriteLine("Girilen en küçük sayı={0}", enKucuk);
            Console.WriteLine("Girilen en büyük sayı={0}", enBuyuk);
            Console.ReadKey();

            return calculator + arithmetic_mean;
        } 


      

    }
}
