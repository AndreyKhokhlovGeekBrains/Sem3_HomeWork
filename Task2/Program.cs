// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты X для точки А: ");
int XA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Y для точки А: ");
int YA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Z для точки А: ");
int ZA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты X для точки B: ");
int XB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Y для точки B: ");
int YB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Z для точки B: ");
int ZB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(
    Math.Pow((XB - XA), 2) +
    Math.Pow((YB - YA), 2) +
    Math.Pow((ZB - ZA), 2)
    );

Console.WriteLine($"Расстояние между точками равняется: {Math.Round(result, 2)}");
