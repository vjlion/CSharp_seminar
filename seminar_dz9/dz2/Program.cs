/*
Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int Sum(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m + Sum(m + 1, n);
}
int M = getUserDate("\nВведите число M -> ");
int N = getUserDate("Введите число N -> ");
Console.WriteLine();
Console.WriteLine(Sum(M, N));