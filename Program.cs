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
                Console.WriteLine("Podaj pierwiastek A");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj pierwiastek B");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj pierwiastek C");
                c = Convert.ToDouble(Console.ReadLine());

                if (a == 0 && a <= 0)
                {
                    Console.WriteLine("A musi być większe od 0");
                }
                else if (b == 0 && b <= 0)
                {
                    Console.WriteLine("B musi być większe od 0");
                }
                else if (c == 0 && c <= 0)
                {
                    Console.WriteLine("C musi być większe od 0");
                }
                else
                {
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

                }
                Console.ReadKey();
                Console.ReadKey();
            }
        }
    }
}
