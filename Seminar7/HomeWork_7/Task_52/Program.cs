/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.*/


int[,] GetMatrix(){
    int Row = Random.Shared.Next(2,6);
    int Columns = Random.Shared.Next(2,6);
    int[,] matrix = new int [Row, Columns];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = Random.Shared.Next(1,10);
        }
    }
    return matrix;
}

void whriteMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine(); 
    }
}

void sumMatrix(int[,] matrix){
    double count = 0;
    for(int i = 0; i < matrix.GetLength(1); i++){
        for(int j = 0; j < matrix.GetLength(0); j++){
            count += matrix[j,i];
        }
        count /= matrix.GetLength(1)-1;
        Console.Write(Math.Round(count,2) + " \t");
        count = 0;
    }

}
int[,] Matrix = GetMatrix();
whriteMatrix(Matrix);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
sumMatrix(Matrix);