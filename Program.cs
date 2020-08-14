using System;


namespace Faktöriyel_Hesaplama
{
    class Program
    {
        public static int Faktöriyel(int sayi) // Faktöriyel Fonksiyonunun oluşturulması(özyinelemeli)
        {
            if (sayi == 0)
            {
                return 1;
            }
            else
            {
              ///  Console.WriteLine(sayi + " ! faktöriyel:" + sayi * Faktöriyel(sayi - 1));

                return sayi * Faktöriyel(sayi - 1);
            }
        }
        static void Main(string[] args)
        {
          
            Console.Write("Bir sayi giriniz:");   // klavyeden faktöriyeli hesaplanacak sayının alınması

            int s = Convert.ToInt32(Console.ReadLine()); // alınan sayının bir s değişkenine atanması.

            Console.WriteLine(s + " ! faktöriyel:" + Faktöriyel(s));
           
            Console.ReadKey();

        }
    }
}
