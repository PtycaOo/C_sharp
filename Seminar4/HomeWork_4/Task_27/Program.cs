int x = Convert.ToInt32(Console.ReadLine());
int y = 0;
while(x!=0){
y = y + x%10;
x/=10;
}
Console.WriteLine(y);