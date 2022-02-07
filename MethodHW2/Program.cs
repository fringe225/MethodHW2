using System;

namespace MethodHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod -3 integer 
            //parametr qebul edir ve iclerinde en
            //boyuk hansidirsa onu tapib return edir 
            //Eyni sekilde verilmis 4 ve 5 ededin en boyuyunu
            //tapan metodlar da yazin(method overloading)



            //Start

            //bool check;
            //int choice;
            ////int a, b, c, d, e; with swicth region

            //Console.WriteLine("Nece eded daxil edeceksiz ?");
            //while (true)
            //{
            //    check = int.TryParse(Console.ReadLine(), out choice);
            //    if (check && choice>=3 && choice<=5)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Warning!!! Xahiw edirik 3,4 ve ya 5 regemini daxil edesiz :");
            //    }

            //}
            #region Switch case usulu ile
            //switch (choice)
            //{
            //    case 3:
            //        Console.WriteLine("3 Eded daxil Edin: ");
            //        int.TryParse(Console.ReadLine(), out a);
            //        int.TryParse(Console.ReadLine(), out b);
            //        int.TryParse(Console.ReadLine(), out c);
            //        Console.WriteLine($"Bu 3 reqemnen en boyuyu - {CompareInt(a, b, c)}");
            //        break;
            //    case 4:
            //        Console.WriteLine("4 Eded daxil Edin: ");
            //        int.TryParse(Console.ReadLine(), out a);
            //        int.TryParse(Console.ReadLine(), out b);
            //        int.TryParse(Console.ReadLine(), out c);
            //        int.TryParse(Console.ReadLine(), out d);
            //        Console.WriteLine($"Bu 4 reqemnen en boyuyu - {CompareInt(a, b, c, d)}");
            //        break;
            //    case 5:
            //        Console.WriteLine("5 Eded daxil Edin: ");
            //        int.TryParse(Console.ReadLine(), out a);
            //        int.TryParse(Console.ReadLine(), out b);
            //        int.TryParse(Console.ReadLine(), out c);
            //        int.TryParse(Console.ReadLine(), out d);
            //        int.TryParse(Console.ReadLine(), out e);
            //        Console.WriteLine($"Bu 5 reqemnen en boyuyu - {CompareInt(a, b, c, d, e)}");
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            #region Solution with loop
            //int[] arr = new int[choice];
            //Console.WriteLine($"Xahiw edirik {choice} dene eded daxil edin : ");
            //for (int i = 0; i < choice; i++)
            //{
            //   int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //switch (choice)
            //{
            //    case 3:
            //        Console.WriteLine($"Bu 3 reqemnen en boyuyu - {CompareInt(arr[0], arr[1], arr[2])}");
            //        break;
            //    case 4:
            //        Console.WriteLine($"Bu 4 reqemnen en boyuyu - {CompareInt(arr[0], arr[1], arr[2],arr[3])}");
            //        break;
            //    case 5:
            //        Console.WriteLine($"Bu 5 reqemnen en boyuyu - {CompareInt(arr[0], arr[1], arr[2],arr[3],arr[4])}");
            //        break;
            //    default:
            //        break;
            //}
            #endregion
            #endregion

            #region task 2

            // Gonderilmis ededin reqemlerinin cemini qaytaran metod 
            //-misalcun bu metodu call ederken arqument olaraq 451 gondersek 
            //metoddan geriye 10 qayitmalidir


            //    int number;
            //    bool check;

            //    Console.WriteLine("Eded daxil edin : ");
            //    while (true)
            //    {
            //        check = int.TryParse(Console.ReadLine(), out number);
            //        if (check && number>=0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Warning!!! Xahiw edirik duzgun daxil edin :");
            //        }

            //    }

            //    Console.WriteLine($"{number} ededinin reqemlerinin cemi - {SumOfNumber(number)} edir");


            #endregion

            #region task3
            //Supermarketdə belə bir aksiya keçirilir: “İstənilən iki mal alana üçüncüsü pulsuz verilir,
            //    ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.Alınacaq 3 məhsulun qiyməti verilmişdirsə ödəniləcək 
            //    məbləği hesbalayan metod yazin -yəni metodunuz 3 doubel parameter qebul edib en boyuk ikisinin cemini hesablayib 
            //    qaytarmalidir

            //double priceOne=0, priceTwo=0, priceThree=0;
            //int count = 3;
            //bool check = true;
            //Console.WriteLine("3 eded daxil edin.\n Birinci regemi daxil edin:  ");
            //while (check || count!=0)
            //{
            //    if (count == 3)
            //    {
                   
            //        check = double.TryParse(Console.ReadLine(), out priceOne);
            //        if (!check)
            //        {
            //            Console.WriteLine("Warning!!! Birinci regemi duzgun daxil edin!");
            //        }
            //        else if (check)
            //        {
            //            Console.WriteLine("Ikinci regemi daxil edin: ");
            //            count--;
            //            continue;
            //        }
            //    }else if (count == 2)
            //    {
            //        check = double.TryParse(Console.ReadLine(), out priceTwo);
            //        if (!check)
            //        {
            //            Console.WriteLine("Warning!!! ikinci regemi duzgun daxil edin!");
            //        }
            //        else if (check)
            //        {
            //            Console.WriteLine("Ucuncu regemi daxil edin: ");
            //            count--;
            //            continue;
            //        }
            //    }else if( count == 1)
            //    {
            //        check = double.TryParse(Console.ReadLine(), out priceThree);
            //        if (!check)
            //        {
            //            Console.WriteLine("Warning!!! Ucuncu regemi duzgun daxil edin!");
            //        }
            //        else if (check)
            //        {
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine($"Odeyeceyiniz mebleg = {ProductsPrice(priceOne,priceTwo,priceThree)}");



            #endregion
        }



        static int CompareInt(int a,int b, int c)
        {
            return a > b ? (a > c ? a : c) : (b > c ? b : c);

        }

        static int CompareInt(int a, int b, int c, int d)
        {
            //return a > b && a > c && a > d ? a : ((b > c && b > d) ? b : (c > d ? c : d));
            int max = CompareInt(a, b, c);
            return max > d ? max : d;

        }

        static int CompareInt(int a, int b, int c, int d,int e)
        {

            //return a>b && a>c && a>d && a>e ? a:((b>c && b>d && b>e)?b:((c>d && c>e) ? c: (d>e?d:e)));

            int max = CompareInt(a, b, c, d);
            return max > e ? max : e;
        }

        static int SumOfNumber(int number)
        {
            int sum = 0;
            int temp;
            while (number != 0)
            {
                temp = number % 10;
                number /= 10;
                sum += temp;
            }

            return sum;
        }

        static double ProductsPrice(double priceOne,double priceTwo, double priceThree)
        {
            double sum;
            double maxPrice = priceOne>priceTwo?(priceOne>priceThree? priceOne:priceThree):(priceTwo>priceThree? priceTwo:priceThree);
            if (maxPrice == priceOne)
            {   
                return sum = maxPrice+ (priceTwo > priceThree ? priceTwo : priceThree);
            }else if (maxPrice == priceTwo)
            {
                return sum = maxPrice + (priceOne > priceThree ? priceOne : priceThree);
            }
            else
            {
                return sum =  maxPrice + (priceOne > priceTwo ? priceOne : priceTwo);
            }
                
                    

        }
    }
}
