using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev20
{
    internal class Get_Number
    {
        public static int Number()
        {
            Console.WriteLine("Sayıyı giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
