namespace Ödev1;

public class Process
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

    public static string Selected_process()
    {
        Console.WriteLine("Yapmak istediğiniz işlemi giriniz(+,-,*,/)");
        return Console.ReadLine();
    }


    public static int Calculator_sum()
    {
        int number_1 = Get_Number_1();
        int number_2 = Get_Number_2();

        string selected_proces = Selected_process();

        if (selected_proces == "+")
        {
            int calculator_sum = number_1 + number_2;

            Console.WriteLine("Toplama İşlemi Sonucu:"+calculator_sum);
            
        }

        return Calculator_sum();
    }

    public static int Extraction_sum()
    {
        int number1 = Get_Number_1();
        int number2 = Get_Number_2();

        string selected_process = Selected_process();

        if (selected_process == "-")
        {
             int Extractions_sum = number1 - number2;

            Console.WriteLine("Çıkarma Sonucu İşlemi:"+Extractions_sum);
            
        }
        return Extraction_sum();
    }

    public static int İmpacth_sum()
    {
        int number1 = Get_Number_1();
        int number2 = Get_Number_2();

        string selected_process = Selected_process();

        if (selected_process == "*")
        {
            int İmpacth_sum = number1 * number2;

            Console.WriteLine("Çarpma İşlemi Sonucu:"+İmpacth_sum);
            
        }

        return İmpacth_sum();
    }

    public static int Divide_sum()
    {
        int number1 = Get_Number_1();
        int number2 = Get_Number_2();

        string process = Selected_process();

        if (process == "/")
        {
            int Divide_sum = number1 / number2;

            Console.WriteLine("Bölme İşlemi Sonucu:" + Divide_sum);

        }

        return Divide_sum();
    }
}