﻿/*Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/
int[] arr = new int [8];
for(int i = 0; i < arr.Length; i++){
    arr[i] = Random.Shared.Next(2);
    Console.Write(arr[i]);
    if(i < arr.Length - 1){
        Console.Write(","); 
    }
}
