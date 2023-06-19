Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int y = x;
int reverce = 0;
while(x !=0){
    reverce = reverce*10 + x%10;
    x/=10;
}

if(y == reverce){
    Console.WriteLine("Полиндром");
} else {
    Console.WriteLine("Найн, нихт");
}