using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev11
{
    internal class İnformations_Control
    {
        public static string Name_and_password_Control()
        {
            int i = 0;

            while (i < 3) {

                int name = Selected_informations.Get_Name();
                int password = Selected_informations.Get_Password();

                if (name == 12 && password == 1234)
                {
                    Console.WriteLine("Giriş Başarlı");
                }

                else
                {
                    Console.WriteLine("Giriş Başarısız");
                }
                
            }
            return Name_and_password_Control();
        }
    }
}
