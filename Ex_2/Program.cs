﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите число X1: ");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число Y1: ");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число Z1: ");
double Z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число X2: ");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число Y2: ");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число Z2: ");
double Z2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2) + Math.Pow((Z1 - Z2), 2));

Console.WriteLine($"{d}");