﻿/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
void rec(int Finish){
    if(Finish == 0) return;
    Console.Write(Finish + " ");
    rec(Finish-1);
    
}

rec(x);