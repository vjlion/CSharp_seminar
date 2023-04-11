/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
int summa(int a)
{
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum += a % 10;
        a = a / 10;
    }
    return sum;
}

int a = getUserDate("Введите число ");
int sum = summa(a);
Console.WriteLine(sum);