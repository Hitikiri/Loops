using System;

namespace loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            //üs hesabı
            int x, y;
            Console.WriteLine("lütfen taban sayısı giriniz");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen üsünü giriniz");
            y=Convert.ToInt32(Console.ReadLine());

            int total = x;
            for (int i = 1; i < y; i++)

            {
                total *= x;
            }
            Console.WriteLine("sonuc:"+total);

        }
    }
}