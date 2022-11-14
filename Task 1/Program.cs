/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

/*Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 0)
{

}
*/






Console.WriteLine("Введите число ");
string number = Console.ReadLine();

int numLength = number.Length;
int[] sum = new int[numLength];
//int summary = 0;

for (int i = 0; i < numLength; i++)
{
    string digit = number[i].ToString();
    sum[i] = Convert.ToInt32(number[i]);
    /*for (int j = 0; j < sumLength; j++)
    {     
        summary = summary + sum[i];
    }  */
}

Console.WriteLine(sum[2]);

/*Console.WriteLine("Введите число ");
string number = Console.ReadLine();

int Sum (string number, int digit)
{
    int result = 0;

    int length = number.Length;
    for (int i = 0; i < length; i++)
    {
        digit = Convert.ToInt32(number[i]);
        result = result + digit;
    }
    return result;
}

int sum = Sum(number, 0);
Console.WriteLine($"{number} -> {sum}");*/