using System;

namespace loop3
{
    class Program
    {
        static void Main(string[] args)
        {
            //factorial
            int x, fac=1;
            Console.WriteLine("bir sayı giriniz");
            x=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                fac *= i;
                
            }   Console.WriteLine("Yazdığınız sayının faktöriyeli:"+fac);
        }
    }
}