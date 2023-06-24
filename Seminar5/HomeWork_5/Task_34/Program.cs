/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


int[] GetArreys(){
    int[] arr = new int[4];
    for(int i = 0; i < arr.Length;i++){
        arr[i] = Random.Shared.Next(100,1000);
    }
    return arr;
}

int Positivcount(int[] arr){
    int count = 0;
    for(int i = 0; i < arr.Length;i++){
        if(arr[i]%2 == 0){
            count++;
        }
    }
    return count;
}
int[] arr = GetArreys();
Console.WriteLine(("Мой массив:\t") + string.Join(", ",arr));
Console.WriteLine($"Колличество четных чисел:\t{Positivcount(GetArreys())}");