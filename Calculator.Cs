using System;

class Program
{
    static void Main()
    {
        Console.Write("¬ведите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("¬ведите оператор (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("¬ведите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        if (op == "+") result = a + b;
        else if (op == "-") result = a - b;
        else if (op == "*") result = a * b;
        else if (op == "/") result = a / b;

        Console.WriteLine("–езультат: " + result);
    }
}