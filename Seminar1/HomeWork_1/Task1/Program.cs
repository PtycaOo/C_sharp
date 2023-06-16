/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите первый оператор");
int numberInt_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй оператор");
int numberInt_2 = Convert.ToInt32(Console.ReadLine());
if(numberInt_1 > numberInt_2){
    Console.WriteLine("Наибольшее число: "+ numberInt_1);
} else {
    Console.WriteLine("Наибольшее число: "+ numberInt_2);
}


