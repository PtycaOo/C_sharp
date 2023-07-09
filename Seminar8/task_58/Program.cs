/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
6 16
9 6*/

int[,] GetRandomMatrix(){
    int row = 2;
    int column = 2;
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
        for(int j = 0; j < matrix.GetLength(1);j++){
            Console.Write($"|{matrix[i,j]}|\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] SumMatrix(int[,] one, int[,] two){
    int[,] res = new int [one.GetLength(0),one.GetLength(1)];
    for(int i = 0; i < one.GetLength(0); i++){
        for(int j = 0; j < one.GetLength(0); j++){
            res[i,j] = one[i,j] * two[i,j];
        }
    }
    return res;
}

int[,] matrixOne = GetRandomMatrix();
PrintMatrix(matrixOne);
int[,] matrixTwo = GetRandomMatrix();
PrintMatrix(matrixTwo);
int[,]sum = SumMatrix(matrixOne,matrixTwo);
PrintMatrix(sum);


