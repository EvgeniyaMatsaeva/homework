// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("введите число");
int a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("введите число");
int b = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("введите число");
int c = Convert.ToInt32 (Console.ReadLine());

if (a>b) 
{
    if(a>c)
    Console.WriteLine(a);
}
if (b>a)
{
    if(b>c)
    Console.WriteLine(b);
}
if (c>a)
{
    if(c>b)
    Console.WriteLine(c);
}