
// Задача 29: Напишите программу, которая задаёт массив из рандомных 8 элементов и выводит их на экран в квадратных скобках.

  Random rnd = new Random();
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
        arr[i] = rnd.Next(0, 20);

    Console.Write("[");
    for (int i = 0; i < 8; i++)
        Console.Write(arr[i] + " ");

    Console.WriteLine("]");