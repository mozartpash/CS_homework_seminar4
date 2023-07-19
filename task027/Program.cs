// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
int GetNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


int Result(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int temp = num % 10;
        sum = sum + temp;
        num = num / 10;
    }
    return sum;

}
int number = GetNumber("Введите ваше число: ");
Console.WriteLine($"Сумма цифр в вашем числе: {Result(number)}");
