// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых на плоскости, 
//           заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//           значения b1, k1, b2 и k2 задаются пользователем.
//           b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//           y = 2x - 1 и y = -3x + 1 -> (0.4, -0.2)
// 1. Написать код для ввода с клавиатуры b1, k1, b2, k2 и конвертации их в числовой тип данных.
// 2. Написать код формулы для вычисления точки пересечения двух прямых
//    Вывести на экран координты х и у, сделать исключение еслипрямые параллельны

// 1.
Console.WriteLine("Введите коэффициент b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициент k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициент b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициент k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

// 2.
double x = (double)(b1 - b2)/(k2 - k1);
double y = Math.Round(k1 * x + b1, 3);

if (y == Math.Round(k2 * x + b2, 3))
{
    Console.WriteLine("Точка пересечения двух прямых имеет координаты: " + "("+x + ";" + y+")");
}
else
{
    Console.WriteLine("Прямые параллельны");
}

