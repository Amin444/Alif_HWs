using System;
using System.Threading;
using System.Collections.Generic;
namespace Deleg
{
    delegate T Func<T>(T x, T y);
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            char z = char.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Func<double> func = Calc.Plus<double>;
            switch (z)
            {
                case '+':
                    {
                        func = Calc.Plus<double>;
                    }
                    break;
                case '-':
                    {
                        func = Calc.Minus<double>;
                    }
                    break;
                case '*':
                    {
                        func = Calc.Multiplication<double>;
                    }
                    break;
                case '/':
                    {
                        func = Calc.Devision<double>;
                    }
                    break;
            }
            Console.WriteLine(func.Invoke(a, b));

        }


    }
    class Calc
    {
        public static T Plus<T>(T x, T y)
        {

            try
            {
                return (dynamic)x + (dynamic)y;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public static T Minus<T>(T x, T y)
        {
            return (dynamic)x - (dynamic)y;
        }
        public static T Multiplication<T>(T x, T y)
        {
            return (dynamic)x * (dynamic)y;
        }
        public static T Devision<T>(T x, T y)
        {
            return (dynamic)x / (dynamic)y;
        }
    }

}
