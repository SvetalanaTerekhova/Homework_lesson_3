// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координаты точки А по оси Х: ");
double Ax = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки А по оси Y: ");
double Ay = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки А по оси Z: ");
double Az = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки B по оси Х: ");
double Bx = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки B по оси Y: ");
double By = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки B по оси Z: ");
double Bz = double.Parse(Console.ReadLine());

double resul = Math.Sqrt(Math.Pow((Ax-Bx),2)+ Math.Pow((Ay-By),2)+Math.Pow((Az-Bz),2));

Console.Write("Ответ: расстояние между точкой А и точкой В равно " + Math.Round(resul,2));