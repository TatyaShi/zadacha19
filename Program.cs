﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine ("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int [5];
array[0] = num / 10000;
array[1] = (num / 1000) % 10;
array[2] = (num / 100) % 10;
array[3] = (num / 10) % 10;
array[4] = num % 10;
if(array[0]== array[^1] && array[1] == array[^2])
Console.WriteLine ("Да, число является палиндромом");
else Console.WriteLine ("Нет, число не является палиндромом");