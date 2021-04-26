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
                double a, b, c, delta, pierw1, pierw2;
                Console.WriteLine("Podaj A");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj B");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj C");
                c = Convert.ToDouble(Console.ReadLine());



                delta = b * b - 4 * a * c;

                if (delta <= 0)
                {
                    Console.Write("Brak pierwiastków");
                }
                else
                {
                    if (delta == 0)
                    {
                        pierw1 = -b / (2 * a);
                        Console.WriteLine("Równanie kwadratowe ma jeden pierwiastek podwójny x1 = " + pierw1);
                    }
                    else
                    {
                        pierw1 = (-b - Math.Sqrt(delta)) / (2 * a);
                        pierw2 = (-b + Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("Równanie kwadratowe ma dwa pierwiastki: x1 = " + pierw1 + " x2 =  " + pierw2);
                    }
                }


                Console.ReadKey();
                Console.ReadKey();
            }
        }
    }
}
