﻿Console.WriteLine("Введите координату по оси Х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по оси У");
int y = Convert.ToInt32(Console.ReadLine());
if(x > 0 && y > 0){
    Console.WriteLine("1"); 
} else if (x < 0 && y > 0){
    Console.WriteLine("2"); 
} else if(x < 0 && y < 0){
    Console.WriteLine("3");
} else if(x > 0 && y < 0){
    Console.WriteLine("4");
} else {
    Console.WriteLine("невозможно определить координатную ось");
}