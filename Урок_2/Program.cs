// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");

 int num = int.Parse(Console.ReadLine());

        int sum = 0;

        while (num > 0)
        {
            sum += num % 10; // Add the last digit of the number to the sum. 

            num /= 10; // Remove the last digit of the number. 

        }

        Console.WriteLine($"Сумма числа равна: {sum}");
