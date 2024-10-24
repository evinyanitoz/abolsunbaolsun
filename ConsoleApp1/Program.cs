namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("1.SAYIYI GİRİN :");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Cİ SAYIYI GİİRN : ");
            int b = Convert.ToInt32(Console.ReadLine());

            //    a = ++b; // a=5 b=9 --------- a=10 , b=9
            //    a = ++b; // a=6 b=1 ------------ a=2 b=1


            //     a = --b;//a=5,b=9 -------- a=8,b=9
            //      a =++b; //a=10 b=9

            //    a = --a;  //a=5 b=7 ------------ a=4 b=7



            //     a = b; // a=2 b=7 --- a=7 b=7

          //  a = +b;     //a=9 b=20---------- a=29 b=20
          //  b = a - b; // 29-20  b=9, a=29
          //  a = a - b; //a=20 b=9 




            a = a+b;     //a=20 b=1---------- a=21 b =1
            b = a - b; //  b=20 a=21
            a= a - b;   


            Console.WriteLine("BİRİNCİ SAYI :"+a);
            Console.WriteLine( "İKİNCİ SAYI:"+b); 



        }
    }
}
