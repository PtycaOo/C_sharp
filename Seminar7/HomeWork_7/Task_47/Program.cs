int Rows = 3;
const int Columns = 4;

double[,] GetRandomMatrix(int row, int columns) {
double[,] matrix = new double[row, columns];   
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
        matrix[i,j] = Math.Round(Random.Shared.Next(-100, 101)*0.1, 1);
        }
    }
return matrix;
}

void PrintMatrix(double[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
        Console.Write($"{matrix[i, j]}\t ");
        }
    Console.WriteLine();
    }
}

double[,] arr = GetRandomMatrix(Rows,Columns);
PrintMatrix(arr);