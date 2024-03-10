using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev14
{
    internal class Note_Process
    {
        public static float Note_sucsess()
        {
            float note = Selected_Note.Student_Note();

            switch (note)
            {
                case 10:
                    Console.WriteLine("A+");
                    break;

                case 9:
                    Console.WriteLine("A");
                    break;

                case 7.8f:
                    Console.WriteLine("B");
                        break;
                case 6:
                    Console.WriteLine("C");
                    break;
                case 5:
                    Console.WriteLine("E");
                    break;
                case 0.4f:
                    Console.WriteLine("F");
                    break;

            }
            return Note_sucsess();
        }
    }
}
