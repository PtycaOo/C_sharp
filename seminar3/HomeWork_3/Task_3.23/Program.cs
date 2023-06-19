Console.WriteLine("Внесите число!!!");
int N = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= N; i++){
    double res = Math.Pow(i,3);
    Console.Write(res);
    if(i < N){
        Console.Write(", ");
    }
    
}