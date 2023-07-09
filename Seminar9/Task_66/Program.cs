/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите начало отсчета: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int y = Convert.ToInt32(Console.ReadLine());
int rec(int x, int y){
    if(x > y) return 0;
    return x + rec(x+1,y);
    
    
}
Console.WriteLine($"Сумма чисел всей последовательности: {rec(x,y)}");
