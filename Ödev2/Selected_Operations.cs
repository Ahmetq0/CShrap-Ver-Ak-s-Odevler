using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
    internal class Selected_Operations
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

        public static string Selected_proces()
        {
            Console.WriteLine("Yapmak istediğiniz işlemi giriniz(+,-,*,/)");
            string process = Console.ReadLine();
            return process;
        }

        public static int Calculator_operation()
        {
            int number1 = Get_Number_1();
            int number2 = Get_Number_2();

            

          

                    int calculator_sum = number1 + number2;
                    Console.WriteLine("Toplama İşlemi Sonucu:"+calculator_sum);
                
            return Calculator_operation();
        }

        public static int Extraction_operation()
        {
            int number1 = Get_Number_1();
            int number2 = Get_Number_2();

            



            int extraction_sum = number1 - number2;
                    Console.WriteLine("Çıkarma İşlemi Sonucu:" + extraction_sum);
                   
            return Extraction_operation();
        }

        public static int İmpacht_operation()
        {
            int number1 = Get_Number_1();
            int number2 = Get_Number_2();

            


            int İmpcath_sum = number1 * number2;
                    Console.WriteLine("Çarpma İşlemi Sonucu:" + İmpcath_sum);
                  
            return İmpacht_operation();
        }

        public static int Divide_Operation()
        {
            int number1 = Get_Number_1();
            int number2 = Get_Number_2();

            




            int divide_sum = number1 / number2;
                    Console.WriteLine("Bölme İşlemi Sonucu:" + divide_sum);
                    
            return Divide_Operation();
        }
        
    }
}
