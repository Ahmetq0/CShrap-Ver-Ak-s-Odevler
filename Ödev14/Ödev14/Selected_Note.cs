using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev14
{
    internal class Selected_Note
    {
        public static float Student_Note()
        {
            Console.WriteLine("Notunuzu Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
