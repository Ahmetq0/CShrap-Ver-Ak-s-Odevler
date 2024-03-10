using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev11
{
    internal class Selected_informations
    {
        public static int Get_Name()
        {
            Console.WriteLine("Kullancı adınızı giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int Get_Password()
        {
            Console.WriteLine("Şifrenizi giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
