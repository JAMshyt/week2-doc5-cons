using System;

namespace Исключение_1
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                if (x == 2) throw new Exception("Логарифм нуля = бесконечности");
                else return Math.Log(Math.Abs(x - 2));
            }
            catch (Exception)
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Начало ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Конец ");
                    double b = double.Parse(Console.ReadLine());
                    if (a >= b)
                    {
                        Console.WriteLine("Начало должно быть меньше Конца");
                    }
                    else
                    {
                        Console.Write("Шаг ");
                        double h = double.Parse(Console.ReadLine());

                        for (double i = a; i <= b; i += h)
                            try
                            {
                                Console.WriteLine("y({0})={1:f4}", i, f(i));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                    }
                }
                catch
                {
                    Console.WriteLine("Неверный формат ввода данных");
                }
            } while (true);
        }

    }
}
