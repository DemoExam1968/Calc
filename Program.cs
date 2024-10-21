using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultAdd, resultSub, resultMul, resultDiv;
            double sin, cos, pow, sqrt;

            Console.WriteLine("Введите первое число ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            b = Convert.ToInt32(Console.ReadLine());
            resultAdd = a+b;
            Console.WriteLine("Сумма = "+resultAdd);
            resultSub = a - b;
            Console.WriteLine("Разность = " + resultSub);
            resultMul = a * b;
            Console.WriteLine("Умножение = " + resultMul);
            resultDiv = a / b;
            Console.WriteLine("Деление = " + resultDiv);

            sin = Math.Sin(a);
            Console.WriteLine($"sin({a}) = {sin}");
            cos = Math.Cos(a);
            Console.WriteLine($"cos({a}) = {cos}");

            sqrt = Math.Sqrt(a);
            Console.WriteLine($"sqrt({a}) = {sqrt}");
            pow = Math.Pow(a, b);
            Console.WriteLine($"pow({a}, {b}) = {pow}");
            Console.ReadKey();
        }
    }
}
