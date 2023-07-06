int[,] GetRandomMatrix(){
int row = Random.Shared.Next(3,7);
int columns = Random.Shared.Next(3,7);
int[,] matrix = new int[row, columns];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
return matrix;
}

int MatrixElement(int[,] matrix, int row, int col){
    int count = 0;
    if(matrix.GetLength(0) <= row){
            return 0;
        } else if(matrix.GetLength(1) <= col){
            return 0;
        } else {
    for(int i = 0; i <= row; i++){
        for(int j = 0; j <= col; j++){
            count = matrix[i,j];
        }   
    }    
}
    return count;
}

void PrintMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
        Console.Write($"{matrix[i, j]}\t ");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Введите номер строки");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int[,] arr = GetRandomMatrix();
PrintMatrix(arr);
Console.WriteLine("");
if(MatrixElement(arr,row,col) == 0){
    Console.WriteLine("Такого элемента нет");
} else {
   Console.WriteLine(MatrixElement(arr,row,col)); 
}

