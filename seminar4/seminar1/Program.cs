/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int getRandom()
{
    return new Random().Next(0, 2);
}


int[] createMassive(int numberOfarray)
{
    int[] result = new int[numberOfarray];
    
    for (int i = 0; i < numberOfarray; i++)
    {
        result[i] = getRandom();
        

    }
    return result;


}

string showMassive(int[] array)
{
    
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
       
        result = result + $"{array[i]},";

    }
    return result;


}
int numberOfarray = getUserDate("Введите количество элементов");
int[] array = createMassive(numberOfarray);
string strArray = showMassive(array);
Console.WriteLine(strArray);
