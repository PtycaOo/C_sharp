int[,] GetSpiral() {
    int n = 4;
    int[,] result = new int[n, n];

    int pos = 1;
    int count = n;
    int value = -n;
    int sum = -1;

    do {
        value = -1 * value / n;
        for (int i = 0; i < count; i++) {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++) {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
    } while (count > 0);

    return result;
}


void PrintArray(int[,] array) {
    int n = (array.GetLength(0) * array.GetLength(1) - 1).ToString().Length + 1;

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            if(i < 10){
                Console.Write(array[i, j].ToString("00").PadLeft(n, ' '));
            } else {
                Console.Write(array[i, j].ToString().PadLeft(n, ' '));
            }
        }
        Console.WriteLine();
    }
}
int[,] matrix = GetSpiral();
PrintArray(matrix);

