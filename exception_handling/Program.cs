using System;

namespace DivisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = DivideNumbers(num1, num2);
                Console.WriteLine($"Результат деления: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка: введено нечисловое значение.");
                Console.WriteLine($"Сообщение: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
                Console.WriteLine($"Сообщение: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла неожиданная ошибка.");
                Console.WriteLine($"Сообщение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
            finally
            {
                Console.WriteLine("Программа завершена.");
            }
        }

        static double DivideNumbers(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Попытка деления на ноль.");
            }
            return a / b;
        }
    }
}

