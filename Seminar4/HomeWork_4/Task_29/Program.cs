int[] GetRandomArr(){
    int[] arr = new int[8];
    for(int i = 0; i < arr.Length; i++){
        arr[i] = Random.Shared.Next(0,9);
    }
    return arr;
}

int [] arr = GetRandomArr();
Console.WriteLine(string.Join(", ", arr));