/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Введите 1-ю цифру: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ю цифру: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ю цифру: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"Максимальное число: {n1}");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"Максимальное число: {n2}");
} 
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine($"Максимальное число: {n3}");
}
else
{
    Console.WriteLine("Цифры равны");
}