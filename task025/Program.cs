// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Result(int a, int b)
{
    int result = 0;
    int temp = a;
    for (int count = 1; count < b; count++)
    {
        result = temp * a;
        temp = temp * a;
    }
    return result;
}

int a = GetNumber("Введите первое число: ");
int b = GetNumber("Введите второе число: ");
Console.WriteLine($"Ваше первое число в степени второго = {Result(a, b)}");


