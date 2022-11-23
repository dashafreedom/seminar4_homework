/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int n = ReadInt ("Введите число: ");
int sum = 0;

while(n > 0)
{
    int b = n % 10;
    n = n / 10;
    sum = sum + b;
}

Console.WriteLine("-> " + sum);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 


