using System;

class Calculator
{

    static double ReadNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
                return number;
            else
                Console.WriteLine("Ошибка: введите корректное число.");
        }
    }


    static string ReadOperator()
    {
        while (true)
        {
            Console.Write("Введите оператор (+, -, *, /): ");
            string op = Console.ReadLine();
            if (op == "+" || op == "-" || op == "*" || op == "/")
                return op;
            else
                Console.WriteLine("Ошибка: допустимы только +, -, *, /.");
        }
    }

    static double Calculate(double a, string op, double b)
    {
        switch (op)
        {
            case "+": return a + b;
            case "-": return a - b;
            case "*": return a * b;
            case "/":
                if (b == 0)
                    throw new DivideByZeroException("Деление на ноль невозможно.");
                return a / b;
            default:
                throw new InvalidOperationException("Неизвестный оператор.");
        }
    }

    static void Main()
    {
        Console.WriteLine("=== Калькулятор ===");

        while (true)
        {
            try
            {
                double a = ReadNumber("Введите первое число: ");
                string op = ReadOperator();
                double b = ReadNumber("Введите второе число: ");

                double result = Calculate(a, op, b);
                Console.WriteLine($"Результат: {a} {op} {b} = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Непредвиденная ошибка: " + ex.Message);
            }

            Console.Write("Хотите выполнить ещё одно вычисление? (y/n): ");
            if (Console.ReadLine().ToLower() != "y")
                break;
        }

        Console.WriteLine("Программа завершена.");
    }
}