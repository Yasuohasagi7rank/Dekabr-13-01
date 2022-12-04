using System;

namespace Lab2Dekabr
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 4;
            double e = 0.001;

            double x = chord(a, b, e);
            Console.WriteLine("Метод хорд: " + x);

            Console.ReadLine();
        }

        public static double chord(double z, double x, double e)
        {
            double xnext = 0;
            double tmp;

            do
            {
                tmp = xnext;
                xnext = x - f(x) * (z - x) / (f(z) - f(x));
                z = x;
                x = tmp;
            }
            while (Math.Abs(xnext - x) > e);

            return xnext;
        }

        public static double f(double x)
        {
            return Math.Cos(x) + Math.Pow(Math.E, -x);
        }
    }

}
