using System;

namespace Lab3Dekabr
{
    class Program
    {
        static void Main(string[] args)
        {

            double a1 = 7;
            double b1 = 9;
            double c1 = -7;
            double d1 = -1;
            double p = 0;
            double h1 = 4;
            double x11 = 5;
            double x21 = 3;

            double f = a1 * x11 + b1 * x21 + c1 * Math.Pow(x11, 2) + d1 * Math.Pow(x21, 2) + p;
            Console.WriteLine("Введите значение I:");
            double i = double.Parse(Console.ReadLine());

            double func1 = Math.Pow(x11, i) - h1 * ((d1 * f) / (d1 * Math.Pow(x11, i)));
            Console.WriteLine(func1);
            double func2 = Math.Pow(x21, i) - h1 * ((d1 * f) / (d1 * Math.Pow(x21, i)));
            Console.WriteLine(func2);


            double a2 = 24.0;
            double b2 = 0.8;
            double c2 = 5.76;
            double d2 = 0.34;
            double e = 0.001;
            double h2 = 0.1;
            double x12 = 5;
            double x22 = 3;

            double cx2 = c2 * x12 * x12;
            double dx2 = d2 * x22 * x22;
            double f2 = a2 * x12 + b2 * x22 + Math.Pow(e, cx2 + dx2);
            Console.WriteLine("Введите значение I:");
            double i2 = double.Parse(Console.ReadLine());

            double func12 = Math.Pow(x12, i2) - h2 * ((d2 * f2) / (d2 * Math.Pow(x12, i2)));
            Console.WriteLine(func12);
            double func22 = Math.Pow(x22, i2) - h2 * ((d2 * f2) / (d2 * Math.Pow(x22, i2)));
            Console.WriteLine(func22);
        }
    }

}
