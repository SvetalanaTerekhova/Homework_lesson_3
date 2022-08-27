// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Для получения таблицы введите число больше 1: ");
double number = double.Parse(Console.ReadLine());
while (number < 1)
{
    if (number == 0)
    {
        Console.WriteLine("Для 0 нет таблицы кубов от 1.");
    }
    else
    {
        Console.WriteLine("Вы ввели отрицательное число, для таких чисел не существует таблица кубов от 1.");
        number = Math.Abs(number);
        Console.Write("Возможно вы хотели ввести число " + number + ". Для которого таблицей кубов от 1 будет: ");
        for (int i = 1; i <= number; i++)
        {
            Console.Write(Math.Pow(i, 3) + "; ");
        }
    }
    Console.WriteLine("Для получения таблицы введите число больше 1: ");
    number = double.Parse(Console.ReadLine());
}
Console.Write("Ответ: таблица кубов для " + number + " -> ");
for (int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 3) + ";");
}