﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
    Console.WriteLine("I четверть");
if (x<0 && y>0)
    Console.WriteLine("II четверть");
if (x<0 && y<0)
    Console.WriteLine("III четверть");
if (x>0 && y<0)
    Console.WriteLine("IV четверть");