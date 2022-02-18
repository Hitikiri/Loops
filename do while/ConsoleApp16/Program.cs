using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
         {
        //
        // string kullaniciadi = "admin";
        // string giris = "";
        // do
        // {
        //     Console.Clear();
        //     Console.WriteLine("kullanici adını giriniz:");
        //     giris = Console.ReadLine();
        //     
        // } while (giris != kullaniciadi);
        // Console.WriteLine("giris basarili");
        //
        //
        int toplam = 0, ortalama, sayac = 0, giris;
        
        do
        {
            Console.WriteLine("sayı giriniz yada çıkmak için -1 e basınız");
            giris=Convert.ToInt32(Console.ReadLine());
            if (giris != -1)
            {
                toplam += giris;
                sayac++;

            }
        } while (giris!=-1 );

        ortalama = toplam / sayac;
        Console.WriteLine("ortalamanız"+ortalama);



         }
        
        
        
    }
}