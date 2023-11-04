using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            //İki adet int değişken tanımlayınız. Bu iki sayının arkadaş sayı olup olmadığını console çıktısı olarak veriniz.
            //(Arkadaş sayının ne olduğunu arama motorundan bulabilirsiniz.)
            // a sayısının çarpanları toplamı b sayısı, ve b sayısının çarpanları toplamı a ise, a ve b sayıları arkadaş sayılardır. 220 ve 284 arkadaştır.

            while(true)
            {
                Console.Write("Birinci Tam Sayıyı Girin :");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ikinci Tam Sayıyı Girin :");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                int toplam1 = 0;
                int toplam2 = 0;

                Console.WriteLine("");
                Console.WriteLine("Birinci tam sayi carpanlari");
                for (int i = 1; i <= sayi1; i++)
                {
                    if (sayi1 % i == 0)
                    {
                        toplam1 = toplam1 + i;
                    }
                }
                int sonuc1 = toplam1 - sayi1;
                Console.WriteLine("Sonuc:" + (sonuc1));

                Console.WriteLine("");
                Console.WriteLine("Ikinci tam sayi carpanlari");
                for (int j = 1; j <= sayi2; j++)
                {
                    if (sayi2 % j == 0)
                    {
                        toplam2 = toplam2 + j;
                    }
                }
                int sonuc2 = toplam2 - sayi2;
                Console.WriteLine("Sonuc:" + (sonuc2));

                if (sayi1 == sonuc2 && sayi2 == sonuc1)
                {
                    Console.WriteLine("Bu iki sayi arkadas sayidir.");
                }
                else
                {
                    Console.WriteLine("Bu iki sayi arkadas sayi degildir.");
                }
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("");
            }

        }
    }
}
