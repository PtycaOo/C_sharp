
int[] GetRandomArr(){
    int[] arr = new int[4];
    for(int i = 0; i < arr.Length; i++){
        arr[i] = Random.Shared.Next(-4,5);
    }
    return arr;
}

int[] ArrReverce(int [] arr){
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] < 0){
            arr[i] = -arr[i];
        } else if(arr[i] > 0){
            arr[i] = -arr[i];
        } else {
            arr[i] = 0;
        }
    }
    return arr;
}
int[] NewArr = GetRandomArr();
int[] MySumPositive = ArrReverce(NewArr);
Console.WriteLine(string.Join(", ",MySumPositive));
