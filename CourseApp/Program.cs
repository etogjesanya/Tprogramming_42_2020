﻿using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            var term1 = Math.Pow(a, Math.Pow(x, 2) - 1);
            var term2 = Math.Log10(Math.Pow(x, 2) - 1);
            var term3 = Math.Pow(Math.Pow(x, 2) - 1, 1 / 3.0);
            var y = term1 - term2 + term3;
            return y;
        }

        public static(double x, double y)[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            var res = new(double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
            int i = 0;
            for (var x = xn; x <= xk; x += dx)
            {
                var y = Calc(a, b, x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static(double x, double y)[] TaskB(double a, double b, double[] xItems)
        {
            var res = new(double, double)[xItems.Length];
            int i = 0;
            foreach (var x in xItems)
            {
                var y = Calc(a, b, x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            const double a = 1.6;
            const double b = 0.0;
            Console.WriteLine($"--------- TASK A ----------");
            var taskA = TaskA(a, b, 1.2, 3.7, 0.5);
            foreach (var item in taskA)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B ----------");
            double[] xItems = { 1.28, 1.36, 2.47, 3.68, 4.56 };
            var taskB = TaskB(a, b, xItems);
            foreach (var item in taskB)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"------- Hello World -------");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Alexander Mokhnatkin");
            Console.ReadLine();
        }
    }
}
