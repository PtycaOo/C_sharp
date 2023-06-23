// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetRandomArr(){
    int[] arr = new int[12];
    for(int i = 0; i < arr.Length; i++){
        arr[i] = Random.Shared.Next(-9,10);
    }
    return arr;
}

int SumPositive(int [] arr){
    int result = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] > 0){
            result += arr[i];

        }
    }
    return result;
}

int SumNegativ(int [] arr){
    int result = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] < 0){
            result += arr[i];

        }
    }
    return result;
}

int[] NewArr = GetRandomArr();
int MySumPositive = SumPositive(NewArr);
int MySumNegativ = SumNegativ(NewArr);

Console.WriteLine($"Сумма положительных чисел =  {MySumPositive}");
Console.WriteLine($"Сумма отрицательных чисел чисел = {MySumNegativ}");