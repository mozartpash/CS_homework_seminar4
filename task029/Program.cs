// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int [] number = new int[8];
int [] Fill(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
    num[i] = new Random().Next(0, 10);
    Console.Write($"{num[i]} ");
    }
    return num;
}

// Console.Write(Fill(number)); - почему-то выходит System32

void Print(int[] num)
{
    for (int i = 0; i < num.Length; i++);    
}
Print(Fill(number));
