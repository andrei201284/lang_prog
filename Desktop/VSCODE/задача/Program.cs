/*
Напишите программу, которая на вход принимает два
 целых числа и проверяет является ли первое число квадратом второго.
25 5 -> YES
10 4 -> NO
16 4 -> YES
*/

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a == b * b)
    Console.Write("YES");
else
    Console.Write("NO");
        
