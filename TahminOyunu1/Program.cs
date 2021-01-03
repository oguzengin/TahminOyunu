using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahminOyunu1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seviye belirleyiniz.\n1-Kolay\n2-Orta\n3-Zor");
            byte tercih = byte.Parse(Console.ReadLine());

            if (tercih == 1)
            {
                Random rnd = new Random();
                int sayi = rnd.Next(1,10);
                int tahmin = 0, sayac = 5;
                for (; ; )
                {
                    Console.WriteLine("Bir sayı giriniz:");
                    int girilen = int.Parse(Console.ReadLine());
                    if (girilen == sayi)
                    {
                        Console.WriteLine("Tebrikler doğru bildiniz!");
                        break;
                    }
                    if (girilen>=10 || girilen<=1)
                    {
                        Console.WriteLine("sadece 1 ile 10 arasındaki değerleri girebilirsiniz!");
                    }
                    else
                    {
                        sayac--;
                        Console.WriteLine(sayac + ".Kalan Hakkınız=>" + girilen);
                        if (sayac == 0)
                        {
                            Console.WriteLine("Hakkınız bitmiştir.");
                            Console.WriteLine("Kazanamadınız lütfen yeniden deneyiniz.");
                            break;
                        }
                    }
                }
            }
            else if (tercih == 2)
            {
                Random rnd = new Random();
                int sayi = rnd.Next(1, 50);
                int tahmin = 0, sayac = 4;
                for (; ; )
                {
                    Console.WriteLine("Bir sayı giriniz:");
                    int girilen = int.Parse(Console.ReadLine());
                    if (girilen == sayi)
                    {
                        Console.WriteLine("Tebrikler doğru bildiniz!");
                        break;

                    }
                    if (girilen >= 50 || girilen <= 1)
                    {
                        Console.WriteLine("sadece 1 ile 50 arasındaki değerleri girebilirsiniz!");
                    }
                    else
                    {
                        sayac--;
                        Console.WriteLine(sayac + ".Kalan Hakkınız=>" + girilen);
                        if (sayac == 0)
                        {
                            Console.WriteLine("hakkınız bitmiştir.");
                            Console.WriteLine("Kazanamadınız lütfen yeniden deneyiniz.");
                            break;
                        }
                    }
                }
            }
            else if (tercih == 3)
            {
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                int tahmin = 0, sayac = 4;
                for (; ; )
                {
                    Console.WriteLine("Bir sayı giriniz:");
                    int girilen = int.Parse(Console.ReadLine());
                    if (girilen == sayi)
                    {
                        Console.WriteLine("Tebrikler doğru bildiniz!");
                        break;

                    }
                    if (girilen >= 100 || girilen <= 1)
                    {
                        Console.WriteLine("sadece 1 ile 100 arasındaki değerleri girebilirsiniz!");
                    }
                    else
                    {
                        sayac--;
                        Console.WriteLine(sayac + ".Kalan Hakkınız=>" + girilen);
                        if (sayac == 0)
                        {
                            Console.WriteLine("hakkınız bitmiştir.");
                            Console.WriteLine("Kazanamadınız lütfen yeniden deneyiniz.");
                            break;
                        }
                    }
                }
            }
        }
    }
}

