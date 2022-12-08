// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Write("Введите число:()");
int n = int.Parse(Console.ReadLine());
int a = n % 10;
if(n<100)
{
    Console.WriteLine("Третьей цифры в числе нет");
}
else
{
    if(n<1000)
    {
     a = n % 10;
    }
    else 
    {
     while(n>=1000)
        {
        n = n/10;
        }
         a = n % 10;
    }    
    Console.WriteLine($"Третья цифра во введенном числе - {a}");
}
