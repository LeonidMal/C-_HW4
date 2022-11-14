/*Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

int[] array = new int [value];

for (int i = 0; i < value; i++)
{
    Console.Write($"{array[i] = new Random().Next(1, 1000)} ");
} 
