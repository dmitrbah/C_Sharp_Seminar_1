﻿Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine(number + " -> " + square);
Console.WriteLine($"{number} -> {square}");