# C# Veri Akışı Örnekleri

## 01.İlk Uygulamamızda 4 işlemi if,else bloğu ile yaptırıyoruz

## Uygulamamızadan Örnek Kod:

```C#
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
    }
```

## 02:İkinci Uygulamamızı switch case bloğunu ile yapıyoruz:

## Uygulama Örnek Kod:

```C#
static void Main(string[] args)
    {
        switch (Selected_Operations.Selected_proces()) {
            case "+":
        int Calculator = Selected_Operations.Calculator_operation();
                break;

                case "-":
        int Extraction = Selected_Operations.Extraction_operation();
                break;

                case "*":
        int İmpacth = Selected_Operations.İmpacht_operation();

                break;
        int Divide = Selected_Operations.Divide_Operation();
    }
        
     }
```

## 03.Üçüncü Uygulamamız ise girdiğimiz sayının pozitif mi yoksa negatif mi onu kontrol ediyor:

## Uygulama Örnek Kod:

```C#

        public static string Negative()
        {
            int number = Get_Number();

            if (number < 0)
            {
                Console.WriteLine("Girdiğiniz sayı negatiftir");
                
            }
            return Negative();
        }

        public static string Positive() 
        {
            int number = Get_Number();

            if (number > 0) 
            {
                Console.WriteLine("Girdiğiniz sayı pozitiftir");
            }
            return Positive();
        }
```

## 04.Dördüncü Uygulamamız ise 3 adet sayının arasından hangisi en büyük onu buluyor:

## Uygulama Örnek Kod:

```C#

```

## 05.Beşinci Uygulamamız ise eğer 0 saysını girersek uygulamadan çıkış yapıyor onun dışında girdiğimiz sayıları 10 ile çarpıp ekrana yazdırıyor:

## Uygulamamızdan Örnek Kod:

```C#
public static void Number_Control()
        {


            int i = 0;

            while (true)
            {

                int number1 = Selectad_Number.Get_Number();

                if (i == number1)
                {
                    Console.WriteLine("Girdiğiniz Sayı:" + number1);
                    break;
                }

                else if (i != number1)
                {
                    Console.WriteLine("Girdiğiniz Sayı:" + number1 * 10);
                    continue;
                }
                
            }
        }
```

## 06.Altıncı Uygulmamamız ise Kullanıcıdan 2 adet sayı isteyip bu sayıların arasındaki sayıları yazdırıyor:

## Uygulama Örnek Kod:

```C#
        public static void Number_Count()
        {
            int toplam = 0;
            
            int number1 = Selectde_Number.Get_Number_1();
            int number2 = Selectde_Number.Get_Number_2();

            while (number1 < number2)
            {
                Console.WriteLine(number1);
                number1+= 1;

            }
        }
```

## 07.Yedinci Uygulamamız ise kullanıcıdan 2 adet sayı girmesi isteyip bunları topluyor ve eğer kullanıcı 0 girerse uygulamadan çıkış yapılıyor:

## Uygulama Örnek Kod:

```C#
public static void Calculator_Sum()
        {
            int i = 0;
            while (true)
            {
        int number1 =  Get_Number.Get_Number_1();                   int number2 =  Get_Number.Get_Number_2();

                if (number1 == i && number2 == 0)
                {
            Console.WriteLine("Sonuç:" + number1);
                    break;

                }

            else if (number1 != 0 && number2 != 0)
                {

    int calculator_opartion = number1 + number2;

Console.WriteLine("Sonuç:" + calculator_opartion);
                }
            }
        }
```

## 08.Sekizinci Uygulamamız ise ilk olarak 5 adet sayı isteyip bunları topluyor sonra bu sayıların aritmetik ortalamasını alıyor sonra bu girdiğimiz sayların en düşüğü ve en yükseğini bulup ekrana yazdırıyor:

## Uygulama Örnek Kod:

```C#
public static int Five_Process()
        {
            int number1 = Selected_Number.Get_Number_1();
            int number2 = Selected_Number.Get_Number_2();
            int number3 = Selected_Number.Get_Number_3();
            int number4 = Selected_Number.Get_Number_4();
            int number5 = Selected_Number.Get_Number_5();


            int calculator = number1 + number2 + number3 + number4 + number5;

            Console.WriteLine("Toplama İşlemi Sonucu:"+calculator);


            int arithmetic_mean = (number1 + number2 + number3 + number4 + number5)/5;

            Console.WriteLine("Aritmatik Ortalama:" + arithmetic_mean);


            Console.Write("1. sayıyı girin:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int enKucuk = sayi;
            int enBuyuk = sayi;

            int i = 1;
            while (i < 10)
            {
                Console.Write("{0}. sayıyı girin:", i + 1);
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi > enBuyuk)
                    enBuyuk = sayi;

                if (sayi < enKucuk)
                    enKucuk = sayi;

                i++;
            }

            Console.WriteLine("Girilen en küçük sayı={0}", enKucuk);
            Console.WriteLine("Girilen en büyük sayı={0}", enBuyuk);
            Console.ReadKey();

            return calculator + arithmetic_mean;
        } 
```

## 09.Dokuzuncu Uygulamamız ise bir rakam istiyor ve bu rakamın kaç basamaklı olmasını istediğiniz soruyor ve kullanıcı kaç basmaklı olacağını yazıyor ve sonuç ekrana yazdırılıyor:

## Uygulama Örnek Kod:

```C#

        public static int Number()
        {
            Console.WriteLine("Sayı Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int Number2()
        {
            Console.WriteLine("Kaç Basamaklı Olacağını Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int Selected_Process()
        {
            int number1 = Number();
            int number2 = Number2();

            int i = 0;
            while (i < number2) 
            {
                Console.WriteLine("Girilen sayı:"+number1);
                i++;
            }
            return number1;



        }
```

## 10.Uygulamamız ise 1 den 500e kadar olana 3ün ve 5in katlarını ekrana yazdırıyor:

## Uygulama Örnek Kod:

```C#
public static void Digital_Proces()
        {
            int i = 0;
            int a = 500;

            while (i <= 490) {

                if (15 % 3 == 0 && 15 % 5 == 0)
                {

                    int total = i+=15;
                    Console.WriteLine(total);
                    
                }
            }
        }
```

## 11.Uygulamamız ise Bir giriş kontrol paneli yapıyoruz:

## Uygulama Örnek Kod:

```C#

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
```

## 12.Uygulamamız ise Kullanıcıdan 2 adet sayı isteyip bu sayıları bölüp yazdıran ve kalanlarınıda yazdıran bir uygulamadır eğer 0 girilirse sayı sıfıra bölünemez diye bir hata verir:

## Uygulama Örnek Kod:

```C#
public static void Divide_Opration()
        {
     while (true)                                          int number1 = Selected_Number.Get_Number_1();             int number2 = Selected_Number.Get_Number_2();

              if (number1 == 0 && number2 == 0)
                                            Console.WriteLine("O Girilemez");
                        break;
                    }                          else if (number1 != 0 && number2 != 0)
                    {
  int divide_sum =number1 number2                                                    Console.WriteLine("Bölme işlemi sonucu:" + divide_sum);                                     int divide_mod_sum = number2 % number1;

                        Console.WriteLine("Bölmeden Kalan:" + divide_mod_sum);
                        continue;
                        
                    }
                }
            }
```

## 13.Uygulamamız ise x ve y sayılarını isteyip full çarpım tablosu yazdırılacaktır:

## Uygulama Örnek Kod:

```C#
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
```

## 14.Uygulamamız ise bir öğrencinin notunu hesaplayıp ona göre not işareti veren uygulamadır:

## Uygulama Örnek Kod:

```C#
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
```

## 15.Uygulamamız ise for , while ve do while döngüsünü kullanarak 2 sayı arasındaki sayıları ekrana yazdırıyoruz 3 farklı yöntem ile:

## Uygulama Örnek Kod:

```C#
public static void For_print()
        {
            for (int i = 6; i <=12;i++)
            {
                Console.WriteLine(i);
            }
            
        }

        public static void While_Print()
        {
            int i = 5;

            while (i < 12) 
            {
                i++;
                Console.WriteLine(i);
            }
            
        }

        public static void Do_While_Print()
        {
            int i = 5;

            do
            {
                i++;
                Console.WriteLine(i);
            }
            while (i < 12);
            
        }
```

## 16.Uygulamamız ise giridiğimiz sayı kaç basamaklı onu kontrol ediyor:

## Uygulama Örnek Kod:

```C#
public static void Negative_and_Positive()
        {
            int number = Get_Number.Get_Number_1();

            if (number < 0)
            {
                Console.WriteLine("Bu sayı negatif olduğu için işlem yapılamaz");
            }

            else
            {
                int sayac = 0;

                while (number > 0)
                {
                    number /= 10;
                    sayac++;
                }
                Console.WriteLine("Gridiğiniz sayı" + sayac + "basamaklıdır");
            }
        }
```

## 17.Uygulamamız ise for döngüsünün char yapısını kullanarak alfabenin büyük harflerini yazdırıyor:

## Uygulama Örnek Kod:

```C#
public static void For_Alfabe()
        {
            char değer = (char)65;

            for (char alfabe = değer ; alfabe < 90;  alfabe++ )
            {
                Console.WriteLine(alfabe);
            }
        }
```

## 18.Uygulamamız ise girdiğimiz sayının mutlak değerini gösteren bir uygulamadır:

## Uygulama Örnek Kod:

```C#
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
```

## 19.Uygulamamız ise çarpma işareti kullanmayarak bizden iki sayının çarpmını istiyor:

## Uygulama Örnek Kod:

```C#
public static void Extraction_Oprations()
        {
            
            int number1 = Get_Number.Get_Number_1();
            int number2 = Get_Number.Get_Number_2();

            int number1 , number2 , sonuç = 0;


            for (int i = 0; i < number2; i++)
            {
                sonuç += number1;
            }
        }
```


## 20.Uygulamamız ise giridiğimiz sayı asal sayımı değil mi onu buluyor:

## Uygulama Örnek Kod:

```C#
public static void Yes_Asal_and_No_Asal()
        {
            int kontrol = 0;

            int number = Get_Number.Number();

            int i = 2;
            while (i < number)
            {
                if (number % i == 0)

                    kontrol++;

                i++;
            }   

                if (kontrol != 0) 
                {
                    Console.WriteLine("Girdiğiniz sayı bir asal sayı değildir");
                }

                else
                {
                    Console.WriteLine("Girdiğiniz sayı asal sayıdır");
                }
                Console.ReadKey();
            }
```

## 21.Uygulamamız ise 49 dan 3 kadar azalan tek sayıları ekrana yazdır:

## Uygulama Örnek Kod:

```C#
public static void Operation()
        {
            int i = 4;
            int a = 52;

            while (a >= i)
            {
                int total = a-=3;
                Console.WriteLine(total);
            }
        }
```







# Uygulamalarımız bu kadar github sayfamı ziyaret edip kodlarıma baktığınız için teşekkür ederim  
