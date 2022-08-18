//=================Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введи число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введи степень для первого числа: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Math.Pow(a,b));