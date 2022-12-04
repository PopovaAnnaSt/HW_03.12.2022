//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
int result = num;
while (num >= 1000)
{
    num = num / 10;
    if(num < 1000)
    {
        Console.WriteLine($"{result} -> {num % 10}");
    }
}