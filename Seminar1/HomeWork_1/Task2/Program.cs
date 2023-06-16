/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.WriteLine("Введите число 1");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(n1 > n2){
    max = n1;
} else {
    max = n2;
}
if(n3 > max){
    max = n3;
}
Console.WriteLine("Наибольшее из 3х чисел: " + max);

