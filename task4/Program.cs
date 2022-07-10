/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("введите число а");
int a = Convert.ToInt32(Console.ReadLine());
int count=0;
Console.Write(a + " -> ");
while (count<=a)
{  
    count++;
    if (count%2==0) 
    {
        Console.Write(count + " , ");
    }
}

