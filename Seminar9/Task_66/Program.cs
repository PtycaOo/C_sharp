
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


int Perechislenie(int FirstNumber, int LastNumber)
{
    if(FirstNumber >= LastNumber) return FirstNumber;
    return FirstNumber + Perechislenie(FirstNumber + 1, LastNumber);
}

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int S = Perechislenie(M, N);
Console.Write("Сумма цифр = " + S);