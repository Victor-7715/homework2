﻿// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.


    Console.WriteLine("Введите первое число ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число ");
    int num2 = int.Parse(Console.ReadLine());

    if(num1 > num2)
    {
        Console.WriteLine("Первое число " + num1 + " больше чем второе " + num2 + " на " + (num1 - num2));
    }
    else
    {
        Console.WriteLine("Второе число " + num2 + " больше чем первое " + num1 + " на " + (num2 - num1) );    
    }

  