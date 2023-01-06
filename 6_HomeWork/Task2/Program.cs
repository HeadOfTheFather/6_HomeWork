﻿/*
Напишите программу, которая найдёт точку пересечения двух прямых на плоскости, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Please, enter b1 coordinate:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, enter k1 coordinate:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, enter b2 coordinate:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, enter k2 coordinate:");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"{x}, {y}");