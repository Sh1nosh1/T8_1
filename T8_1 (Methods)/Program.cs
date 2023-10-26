using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T8_1__Methods_
{
    internal class Program
    {
        /*public static int Add(int x,int y)
        {
          //Task 
            int sum = x + y;
            WriteLine($"x={x} \t y={y}");
            x = 100;
            y = 500;
            WriteLine($"x={x} \t y={y}");
            return sum;
        }*/

        //Task1,2
        /* static void Func()
        {
            Write($"x= ");
            int x = Convert.ToInt32(ReadLine());
            double y = Math.Pow(x, 2);
            WriteLine($"y= {y}");
        }*/

        //Task3
        /*public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Diff(int x, int y)
        {
            return x - y;
        }
        public static double Div(int x, int y)
        {
            return (double)x / y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }*/
        //task5
        //public static double Func(double x)
        //{
        /*if(x < 5)
        {
           return (4 * Math.Pow(x, 2) + 1) / (x - 5);
        }
        else 
        {
            return 3 * Math.Pow(x, 2) - 2;
        }*/

        /* return x < 5 ? (4 * Math.Pow(x, 2) + 1) / (x - 5) : 3 * Math.Pow(x, 2) - 2;*/
        //}
        //task6
        public static int Max(int a, int b)
        {
           //return a>b ? a : b;
           if(a>b)
            {
                return a;
            }
           else 
            {
                return b;
            }

        }




        static void Main(string[] args)
        {
            try
            {
                //Task
                /*int x = 9;
                int y = 10;
                WriteLine($"x={x} \t y={y}");
                int z = Add(x,y);
                WriteLine($"z={z}");
                WriteLine($"x={x} \t y={y}");*/

                //Task1,2
                /*Func();
                Write($"Введите n ");
                int n= Convert.ToInt32(ReadLine());
                for(int i=0; i <= n; i++)
                {
                    Func();
                }*/

                //Task3
                /*Write("Enter x: ");
                int x = Convert.ToInt32(ReadLine());
                Write("Enter y: ");
                int y = Convert.ToInt32(ReadLine());
                int result = Sum(x, y);
                WriteLine($"Result sum: {result}");
                int result1 = Diff(x, y);
                WriteLine($"Result difference: {result1}");
                double result2 = Div(x, y);
                WriteLine($"Result divide: {result2:f2}");
                int result3 = Mult(x, y);
                WriteLine($"Result multiplication: {result3}");*/

                //taSK  5
                /*Write("Enter x: ");
                int x = Convert.ToInt32(ReadLine());
                double y =Func(x);
                WriteLine($"y= {y}");*/
                Write("Enter a: ");
                int a = Convert.ToInt32(ReadLine());
                Write("Enter b: ");
                int b = Convert.ToInt32(ReadLine());
                int c= Convert.ToInt32(ReadLine());
                int max =Max( Max(a, b),c);
                Write($"Maximum value: {max}");







            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
