﻿/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.WriteLine("введите число а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число c");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b && a>c) 
{
    Console.WriteLine(a + " , " + b +" , " + c + " -> " + a);
}
else if (b>a && b>c) 
{
    Console.WriteLine(a + " , " + b +" , " + c + " -> " + b);
}
else Console.WriteLine(a + " , " + b +" , " + c + " -> " + c);