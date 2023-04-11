/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}
int Delnum(int number)
{
    int s = (number % 100) / 10;
    return s;
}
int randomNunber = GetNumberFromRange(100,999);
int numberWithoutSecond = Delnum(randomNunber) ;
Console.WriteLine($"Число {randomNunber} вторая цифра этого числа {numberWithoutSecond}");