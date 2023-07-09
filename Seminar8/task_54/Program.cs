/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] GetRandomMatrix(){
    int row = 4;
    int column = 4;
    int[,] matrix = new int[row,column];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1);j++){
            matrix[i,j] = Random.Shared.Next(1,9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1);j++){
            Console.Write($"|{matrix[i,j]}|\t");
        }
        Console.WriteLine();
    }
}

int[,] Sortmatrix(int[,] Matrix){
    for(int i = 0; i < Matrix.GetLength(0); i++){
        for(int j = 0; j < Matrix.GetLength(1)-1;j++){
            for(int b = 0; b < Matrix.GetLength(1);b++){
                if(Matrix[i,j] < Matrix[i,j+1]){
                    int temp = Matrix[i, j];
                    Matrix[i, j] = Matrix[i, j+1];
                    Matrix[i, j+1] = temp;
                    j = 0;
                }
            }
        }
    }
    return Matrix;
}

int[,] matrix = GetRandomMatrix();
PrintMatrix(matrix);
Console.WriteLine();
int[,] sortMatrix = Sortmatrix(matrix);
PrintMatrix(sortMatrix);
