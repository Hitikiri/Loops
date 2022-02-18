using System;

namespace Foreach
{
class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[] {1, 2, 3, 4, 5, 20, 232, 2, 4, 5, 62, 2};
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
            
        }
    }
}
}