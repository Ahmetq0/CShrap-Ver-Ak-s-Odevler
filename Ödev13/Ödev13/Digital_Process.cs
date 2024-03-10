using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev13
{
    internal class Digital_Process
    {
        public static int multiplication_table()
        {
            int number1 = Selected_Number.Get_Number_1();
            int number2 = Selected_Number.Get_Number_2();


            Console.WriteLine(number1 + "*1:" + number1 * 1);
            Console.WriteLine(number1 + "*2:" + number1 * 2);
            Console.WriteLine(number1 + "*3:" + number1 * 3);
            Console.WriteLine(number1 + "*4:" + number1 * 4);
            Console.WriteLine(number1 + "*5:" + number1 * 5);
            Console.WriteLine(number1 + "*6:" + number1 * 6);
            Console.WriteLine(number1 + "*7:" + number1 * 7);
            Console.WriteLine(number1 + "*8:" + number1 * 8);
            Console.WriteLine(number1 + "*9:" + number1 * 9);
            Console.WriteLine(number1 + "*10:" + number1 * 10);

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine(number2 + "*1:" + number2 * 1);
            Console.WriteLine(number2 + "*2:" + number2 * 2);
            Console.WriteLine(number2 + "*3:" + number2 * 3);
            Console.WriteLine(number2 + "*4:" + number2 * 4);
            Console.WriteLine(number2 + "*5:" + number2 * 5);
            Console.WriteLine(number2 + "*6:" + number2 * 6);
            Console.WriteLine(number2 + "*7:" + number2 * 7);
            Console.WriteLine(number2 + "*8:" + number2 * 8);
            Console.WriteLine(number2 + "*9:" + number2 * 9);
            Console.WriteLine(number2 + "*10:" + number2 * 10);

            return number1 + number2;


        }
    }
}
