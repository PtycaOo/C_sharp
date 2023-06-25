/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GetArray(){
    int[] arr = new int[4];
    for(int i = 0; i < arr.Length; i++){
        arr[i] = Random.Shared.Next(1,99);
    }
    return arr;
}

int Sum(int[] arr){
    int count = 0;
    for(int i = 1; i < arr.Length;){
        count += arr[i];
        i+=2;
    }
    return count;
}

int[] arr = GetArray();
int x = Sum(arr);
Console.WriteLine(string.Join(", ",arr));
Console.WriteLine(x);