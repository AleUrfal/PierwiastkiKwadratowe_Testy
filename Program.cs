using System;

namespace PierwiastkiKwadratowe_Testy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int t = 0; t <= 100; t++)
            {
                Console.WriteLine("Funkcja:");
                double a, b, c;
                Console.WriteLine("Podaj A");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj B");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj C");
                c = Convert.ToDouble(Console.ReadLine());

                Funkcja funkcja = new Funkcja(a, b, c);
                double[] pierwiastki = funkcja.ObliczPierwiastki();

                if (pierwiastki != null)
                {
                    Console.WriteLine("pierwiastki : ");
                    for (int i = 0; i < pierwiastki.Length; i++)
                    {
                        Console.WriteLine(pierwiastki[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Brak pierwiastków");
                }
             
                Console.ReadKey();
            }
        }
    }
}
