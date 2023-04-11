/*
Задача 41: Пользователь вводит с клавиатуры M чисел. П
осчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
int[] getNumbersKey(int numbers)
{
    int[] resultArray = new int[numbers];
    int numberi = 0;
    for (int i = 0; i < numbers; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write($"Введите {i + 1} число: ");
        Console.ResetColor();
        numberi = Convert.ToInt32(Console.ReadLine());
        resultArray[i] = numberi;
    }
    return resultArray;
}
int getUserNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}
int num = getUserDate("Введите сколько будет чисел: ");
int[] res = getNumbersKey(num);
int user = getUserNum(res);
Console.WriteLine($"Введено чисел больше '0':  {user}");