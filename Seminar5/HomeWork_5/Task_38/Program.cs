double[] GetArray(){
    double[] arr = new double[4];
    for(int i = 0; i < arr.Length; i++){
        arr[i] = Math.Round(Random.Shared.NextDouble() * 10, 2);
    }
    return arr;
}
double GetMaxMin(double[] arr){
    double max = 0.0;
    double min = 10.0;
    double sum = 0.0;
    for(int i = 0; i < arr.Length;i++){
        if(max < arr[i]){
            max = arr[i];
        }
        if(min > arr[i]){
            min = arr[i];
        }
    }
sum = max - min;
return sum;
}

double[] arr = GetArray();
double sum = GetMaxMin(arr);
Console.WriteLine(string.Join(", ",arr));
Console.WriteLine(sum);

