//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 1 Вариант решения через сравнение первой пары чисел и последней пары (в которой предварительно меняем числа местами), условие введения пятизначного числа задано через подсчет количества цифр в числе

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int CountNumber(int arg)
{
    int resul = 0;
    arg = Math.Abs(arg);
    while (arg > 0)
    {
        resul++;
        arg = arg / 10;
    }
    return resul;
}
int count = CountNumber(number);
while (count != 5)
{
    Console.WriteLine("Вы ввели не пятизначное число. Введите пятизначное число: ");
    number = int.Parse(Console.ReadLine());
    count = CountNumber(number);
}
if (number < 0)
{
    Console.Write("Ответ: " + number + " -> отрицательные числа не могут являться палиндромом");
}
if (number > 0)
{
    int number1 = number / 1000;
    int number2 = number % 100;
    number2 = (number2 % 10) * 10 + number2 / 10;
    if (number1 == number2)
    {
        Console.Write("Ответ: " + number + " -> число является палиндромом");
    }
    else
    {
        Console.Write("Ответ: " + number + " -> число не является палиндромом");
    }
}

// 2 Вариант решения через сравнение 1 числа с 5 числом, 2 числа с 4 числом, условие введения пятизначного числа задано через диапазон чисел

/* Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int i = number;
i = Math.Abs(i);
while (i < 10000 || i > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число. Введите пятизначное число: ");
    number = int.Parse(Console.ReadLine());
    i = number;
    i = Math.Abs(i);
}
if (number < 0)
{
    Console.Write("Ответ: " + number + " -> отрицательные числа не могут является палиндромом");
}
if (number > 0)
{
    int number1 = number / 10000;
    int number2 = (number - ((number / 10000) * 10000)) / 1000;
    int number4 = (number / 10) % 10;
    int number5 = number % 10;
    if (number1 == number5 && number2 == number4)
    {
        Console.Write("Ответ: " + number + " -> число является палиндромом");
    }
    else
    {
        Console.Write("Ответ: " + number + " -> число не является палиндромом");
    }
} */