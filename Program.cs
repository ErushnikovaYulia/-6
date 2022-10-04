// Напишите программу, которая на вход принимает число и выдает, является ли четным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число: ");
int i = int.Parse(Console.ReadLine());
 if (i % 2 == 0)
    {
        Console.WriteLine("да четное");
    }
else
    {
        Console.WriteLine("нет, не четное");
    }
 Console.ReadKey();