/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if (k1 == k2)
    {
        Console.Write("Заданные прямые не пересекаются!");
    }
    else
    {
        Console.Write($"Точка пересечения заданных прямых: ({x:0.00}; {y:0.00})");
    }
}

double b1 = getUserDate("Введите b1: ");
double k1 = getUserDate("Введите k1: ");
double b2 = getUserDate("Введите b2: ");
double k2 = getUserDate("Введите k2: ");
CrossPoint(k1, b1, k2, b2);


