﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= n )
{
    Console.WriteLine(Math.Pow(i,2));
    i++;

}