/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}


int getExtOfRange(int start,int end)
{
    int ext = 1;
    for (int i = start; i<=end;i++)
    {
        ext = ext*i  ;
    }
    return ext;
}
int end = getUserDate("Enter A");
int ext = getExtOfRange(1,end);
Console.WriteLine(ext);
