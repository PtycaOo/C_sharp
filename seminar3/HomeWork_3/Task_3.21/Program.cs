int [] arr_1 = new int [3];
int [] arr_2 = new int [3];
Console.WriteLine("Введите 3 коодританы x,y,z первой точки"); 
for(int i = 0; i < 3; i++){
    arr_1[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите 3 коодританы x,y,z второй точки");
for(int j = 0; j < 3; j++){
    arr_2[j] = Convert.ToInt32(Console.ReadLine());
}
double res = Math.Round(Math.Sqrt(Math.Pow(arr_2[0]-arr_1[0],2) + Math.Pow(arr_2[1]-arr_1[1],2) + Math.Pow(arr_2[2]-arr_1[2],2)),2);
Console.WriteLine(res);