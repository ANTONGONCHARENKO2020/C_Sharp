﻿/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
int number = new int();
Console.WriteLine("Введите число");
number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number % 2 ==0);