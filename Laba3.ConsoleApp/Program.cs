// See https://aka.ms/new-console-template for more information
using Laba3.ClassLibrary;

Console.WriteLine("Hello, World!");

Console.WriteLine("Введите длину радиуса меньшего основания усеченного конуса");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину радиуса большего основания усеченного конуса");
double R = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину образующей усеченного конуса");
double l = Convert.ToDouble(Console.ReadLine());

double result = new ClassSquare().S(r, R, l);
Console.WriteLine("Площадь боковой поверхности усеченного конуса равна: " + result);
