/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 9
m = 2, n = 3 -> A(m,n) = 29*/

Console.WriteLine("Введите начало отсчета: ");
uint n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
uint m = Convert.ToUInt32(Console.ReadLine());

uint Akkerman (uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write(Akkerman(n,m));


