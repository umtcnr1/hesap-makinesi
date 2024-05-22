using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            // ilk önce değişkenlerimizi tanımlıyoruz.
            int a, b, sonuc = 0;
            // değişkenlerimize değer aktarılması gerektiğini sölüyoruz.
            Console.WriteLine("\t 1. sayıyı giriniz : ");
            // klavyeden girilen ilk sayıyı "a" değişkenine aktarılmasını sağlıyoruz.
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("\t 2. sayıyı giriniz : ");

            // klavyeden girilen 2. sayının b değişkenine aktarılmasını sağlıyoruz.

            b = int.Parse(Console.ReadLine());

            // işlem seçimi yaptıralım ..
            // işlem tercihini belirlemek için değişken tanımlıyalım.
            int tercih;
            Console.WriteLine("\tToplama işlemi için : 1 \n\t Çıkarma işlemi için : 2  \n\t  Bölme işlemi için : 3 \n\t Çarpma işlemi için : 4 ");
            tercih = int.Parse(Console.ReadLine());
            if (tercih == 1)
            {

                sonuc = a + b;
                Console.WriteLine(sonuc);

            }
            if (tercih == 2)
            {

                sonuc = a - b;
                Console.WriteLine(sonuc);

            }
            if (tercih == 3)
            {

                sonuc = a / b;
                Console.WriteLine(sonuc);

            }

            if (tercih == 4)
            {

                sonuc = a * b;
                Console.WriteLine(sonuc);

            }
            Console.ReadLine();

        }
    }
}
