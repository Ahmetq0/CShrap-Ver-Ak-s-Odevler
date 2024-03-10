using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Ödev18
{
    internal class Process
    {
        public static int Get_Number()
        {
            Console.WriteLine("Sayı giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public static void Operations()
        {
            int number = Get_Number();

            if (number <0)
            {
                int total = (number * -1);
                Console.WriteLine("Mutlak Değer:" + total);
            }

            else
            {
                Console.WriteLine("Mutlak Değer:"+number);
            }
        }
    }
}
