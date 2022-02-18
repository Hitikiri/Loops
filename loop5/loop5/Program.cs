using System;

namespace loop5
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen sayıyı 2 sayının karesi toplamı şeklinde yazılıp
            //yazılamayacağını bulan programı yazınız.
            Console.WriteLine("lütfen bir sayı giriniz");
            int num = Convert.ToInt32(Console.ReadLine());
            bool bulundumu = false;

            for (int i = 0; i < num; i++)
            {
                for (int x = 0; x < num; x++)
                {
                    if (i*i+x*x==num)
                    {
                        bulundumu = true;
                        //Console.WriteLine(i+"*"+i+"+"+x+"*"+x+ "şeklinde yazılabilir");
                        Console.WriteLine("{0} x {0} + {1} x {1} şeklinde yazılabilir",i,x);
                        
                    }
                }
            }

            if (!bulundumu)
            {
                Console.WriteLine("bu sayı 2 sayının karesi şeklinde yazılamaz.");
            }


        }
    }
}