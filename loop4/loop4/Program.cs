using System;

namespace loop4
{
    class Program
    {
        static void Main(string[] args)
        {
            //aklından bir sayı tut

            Random rnd = new Random();
            int tutulansayi = rnd.Next(1, 10);
            int tahmin;
            bool dogrubildi = false;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("tutulan sayıyı giriniz");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin==tutulansayi)

                {
                    dogrubildi = true;
                    break;
                }
            }

            if (dogrubildi)
            {
                Console.WriteLine("doğru bildiniz");
                
            }
            else
            {
                Console.WriteLine("bilemediniz. Tuttuğum sayı:"+tutulansayi);
            }
        }   
    }
}