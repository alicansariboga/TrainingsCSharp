using System;

namespace Odev4
{
    class Program
    {
        static void Main(string[] args)
        {

            // buyukten kucuge siralama
            int[] dizi = new int[3];
            dizi[0] = 5;
            dizi[1] = 12;
            dizi[2] = 9;

            bool islem1 = dizi[0] < dizi[1];
            bool islem2 = dizi[1] < dizi[2];
            bool islem3 = dizi[0] < dizi[2];

            if(islem1 == true)
            {
                if(islem2 == true)
                {
                    if(islem3 == true)
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
