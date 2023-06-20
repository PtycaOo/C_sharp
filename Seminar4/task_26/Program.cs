/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int ReadInt(){
    Console.WriteLine("Введите целое число");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int number_count(int x){
int count = 0;
    while(x !=0){
        x/=10;
        count += 1;
    
    }
return count;
}

int number = ReadInt();
int res = number_count(number);
Console.WriteLine(res);