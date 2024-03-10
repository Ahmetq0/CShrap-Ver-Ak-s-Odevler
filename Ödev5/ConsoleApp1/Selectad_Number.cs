using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Selectad_Number
    {
        public static int Get_Number()
        {
            Console.WriteLine("Sayıyı giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
