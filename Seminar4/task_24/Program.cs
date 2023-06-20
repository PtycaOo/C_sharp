/*Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

int ReadInt(){
    Console.WriteLine("Введите целое число");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int sum(int a){
    int sum = 0;
    for(int i = 0; i <= a; i++){
        sum += i;
    }
    return sum;
}
int value_1 = ReadInt();
int res = sum(value_1);
Console.WriteLine($"Сумма чисел от 1 до {value_1} равно {res}");
