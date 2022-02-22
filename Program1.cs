// See https://aka.ms/new-console-template for more information


using System;
using System.Diagnostics;
namespace LamdaExpExercise
{
    public delegate double MaxOftwo(double a, double b);
    public class Program
    {

        public static void CallAnonymousMethod()
        {
            bool positive = new Func<int, bool>(delegate (int int32)
            {
                return
int32 > 0;
            })(-11);
            new Action<bool>(delegate (bool value)
            {
                Console.WriteLine(value);
            })(positive);
        }
        public static void CallLambda()
        {
            bool positive = new Func<int, bool>(int32 => int32 > 0)(1);
            new Action<bool>(value => Console.WriteLine(value))(positive);
        }

        static void Main()
        {
            Console.WriteLine("\n1) Anonymous Function and ActionDelegate Without Lamda Expression : ");
            Program.CallAnonymousMethod();
            Console.WriteLine("\n2) Anonymous Function and ActionDelegate With Lamda Expression : ");
            Program.CallLambda();
            //delegate with lamda expression
            Console.WriteLine("\n3) Delegate with Lamda Expression : ");
            MaxOftwo parse = (double x, double y) => (x > y ? x : y);
            Console.WriteLine("\nMax(2.3,1.1) = {0}", parse(2.3, 1.1));
            Console.WriteLine("\n4) Function Delegate with Lamda Expression : ");
            Func<double, double, double> f = (x, y) =>
            {
                if (x > y) return x;
                return y;
            };
            double z1 = f(10, 20);
            Console.WriteLine("\nMax(10,20) = {0}", z1);

            Console.WriteLine("\n5) Function Delegate with Diffrent Lamda Expressions : ");
            double z2;
            Func<double, double, double> f2;
            f2 = (x, y) =>
            {
                if (x > y)
                    return x;
                return y;
            };
            z2 = f2(10, 20);
            Console.WriteLine("\nMax(10,20) = {0}", z2);
            // z holds 20.
            f2 = (x, y) =>
            {
                if (x < y)
                    return x;
                return y;
            };
            z2 = f2(10, 20);
            Console.WriteLine("Min(10,20) = {0}\n", z2);
            //z2 holds 10.
        }
    }
}