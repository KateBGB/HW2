//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число:()");
int a = int.Parse(Console.ReadLine());
int b = a / 10;
int c = b % 10;
Console.WriteLine($"Вторая цифра числа: {c} ");
