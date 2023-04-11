/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
int getExtOfRange(int endA, int endB)
{
    int ext = 1;
    for (int i = 1; i <= endB; i++)
    {
        ext = ext * endA;
    }
    return ext;
}
int endA = getUserDate("Введите число A");
int endB = getUserDate("Введите число В");
int ext = getExtOfRange(endA,endB);
Console.WriteLine(ext);