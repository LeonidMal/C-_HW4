/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

for (int i = 0; i < 10; i++)
{
    int a = new Random().Next(1, 10);
    int b = new Random().Next(1, 10);
    Console.WriteLine($"{a}, {b} -> {Math.Pow(a, b)}");
}