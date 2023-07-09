/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
int[,] GetRandomMatrix(){
    int row = Random.Shared.Next(3,7);
    int column = Random.Shared.Next(4,7);
    int[,] matrix = new int[row,column];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1);j++){
            matrix[i,j] = Random.Shared.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
        Console.Write($"|{matrix[i, j]}|\t ");
        }
    Console.WriteLine();
    }
}
int[] sum(int[,] matrix){
    int count = 0;
    int size = matrix.GetLength(0);
    int[] arr = new int[size];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            count += matrix[i,j]; 
        }
        arr[i] = count;
        count = 0;
    }
    Console.WriteLine();
    return arr;
}
int Result(int[] arr){
    int min = 0;
    int minValue = arr[0];
    for(int i = 0; i < arr.Length-1; i++){
        if(arr[i] < minValue){
            minValue = arr[i];
            min = i;
        }
    }
    return min+1;
} 

int[,] OriginMatrix = GetRandomMatrix();
Console.WriteLine("Наш массив:\n");
PrintMatrix(OriginMatrix);
int[] arr = sum(OriginMatrix);
Console.WriteLine("Сумма каждой строки нашего массива:\n");
Console.WriteLine(string.Join (", ",arr));
Console.WriteLine($"Наименьшая сумма в строке: {Result(arr)}\n");
Console.WriteLine($"Хотя по факту в строке: {Result(arr)-1}");
