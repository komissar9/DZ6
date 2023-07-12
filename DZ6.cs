// 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
// Console.Write("Введите количество чисел в строке: ");
// int sizeUser = Convert.ToInt32(Console.ReadLine());
// int [] numbers = new int [sizeUser];
// int count = 0;
// for (int i = 0; i < sizeUser; i++)
// {
//     Console.Write($"Введите {i+1} число: ");
//     numbers [i] = Convert.ToInt32(Console.ReadLine());
//     if (numbers [i]>0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количество положительных чисел {count}");
// Console.WriteLine($"Числа: [ {string.Join("; ", numbers)} ]");

// 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения находится по координатам ХУ: {x}, {y}");