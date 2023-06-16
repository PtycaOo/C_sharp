int num = 0;
string str = "";
Console.WriteLine("Введите число:");
if (Int32.TryParse(Console.ReadLine(), out num))
{

    if (num == 1) { str = "X - 0 до бесконечность, Y - 0 до бесконечность"; 
    } else if (num == 2) {
        str = "X - 0 - минус бесконечность, Y - 0 - бесконечность"; 
    } else if (num == 3) { 
        str = "X - 0 - минус бесконечность, Y - 0 - минус бесконечность"; 
    } else if (num == 4) { 
        str = "X - 0 - бесконечность, Y - 0 - минус бесконечность"; 
    }
    Console.WriteLine(str);
}
else {
    Console.WriteLine("Не число!");
}
