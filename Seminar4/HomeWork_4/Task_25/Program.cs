
int ReadInt(){
    Console.WriteLine("Введите число");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int new_dig (int A, int B){
    int product = A;
    for(int i = 1; i < B; i++){
        product *= A;  
    }
    return product;
}

int res = new_dig(ReadInt(), ReadInt());
Console.WriteLine(res);