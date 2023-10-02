// Напишите программу, который принимает на вход два дробных числа (A и B) и возводит число A
//  в натуральную степень B.

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Введите A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите B: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow(a, b));
    }
}
