using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev6
{
    internal class Selectde_Number
    {
        public static int Get_Number_1()
        {
            Console.WriteLine("1.Sayıyı giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int Get_Number_2() 
        {
            Console.WriteLine("2.Sayıyı giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
