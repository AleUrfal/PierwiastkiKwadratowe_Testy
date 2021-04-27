using System;

namespace PierwiastkiKwadratowe_Testy
{
    public class Funkcja
    {
        public readonly double a, b, c;

        public Funkcja(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double[] ObliczPierwiastki()
        {
            double delta = ObliczDelte();
            
            if (delta < 0)
            {
                return null;
            }
            if (delta == 0)
            {
                double pierw1 = -b / (2 * a);

                return new double[] { pierw1 };
            }
            else
            {
                double pierw1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double pierw2 = (-b + Math.Sqrt(delta)) / (2 * a);

                return new double[] { pierw1, pierw2 };
            }
        }

        public double ObliczDelte()
        {
            return b * b - 4 * a * c;
        }
    }
}