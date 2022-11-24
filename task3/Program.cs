/* Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33] */

int size = ReadInt("Введите число N: ");
int[] numbers = new int[size];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 100);
    WriteArray(numbers[i] + " ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

void WriteArray(string message)
{
    Console.Write(message);
} 