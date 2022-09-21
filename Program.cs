using System;

namespace Döngüler_While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            // 1'den başlayarak consola girilen sayıya kadar (sayı dahil) ortalama hesaplayıp consola yazdıran program.
            Console.Write("Lütfen bir sayi gririniz :");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri consola yazdır.
            char character = 'a';
            while(character < 'z')
            {
                Console.Write(character);
                character ++;
            }

            Console.Write("*****Foreach*****");
            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            
        }
    }
}
