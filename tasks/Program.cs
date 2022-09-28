// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.WriteLine("Enter number A");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter number B");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{A} in pow {B} = {GetApowB(A, B)}");
// int GetApowB(int number1, int number2)
// {
//     int result = 1;
//     for(int i = 1; i <= number2; i++)
//     {
//         result = result * number1;
//     }
//     return result;
// }

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Enter number A ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Sum for digits in {A} = {SumDigits(A)}");
// int SumDigits(int number)
// {
//     int sum = 0;
//     while(number != 0)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     }
//     return sum;
// }

// Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
int[] array = new int[8];
FillArray(array);
PrintArray(array);
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    for(int i = 0; i < lenght; i++)
    {
        collection[i] = new Random().Next(-99, 100);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int pos = 0; pos < count; pos++)
    {
        Console.Write(col[pos] + " ");
    }
}