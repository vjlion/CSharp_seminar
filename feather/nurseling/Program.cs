Console.Clear();

Console.Write("Введите ваше имя: ");
string username = Console.ReadLine()!;
if(username.ToLower() == "маша")
{
   Console.WriteLine("Я так ждал тебя, Маша!");
}
else
{
   Console.Write("Привет, ");
   Console.WriteLine(username);
}