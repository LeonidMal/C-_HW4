/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

Console.WriteLine("Введите число ");
string number = Console.ReadLine();

int numLength = number.Length;
int[] sum = new int[numLength];
int summary = 0;

for (int i = 0; i < numLength; i++)
{
    string digit = number[i].ToString();
    sum[i] = Convert.ToInt32(digit);
    summary = summary + sum[i];
    
}

Console.WriteLine(summary);
