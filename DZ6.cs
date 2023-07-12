// 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.Write("Введите количество чисел в строке: ");
int sizeUser = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [sizeUser];
int count = 0;
for (int i = 0; i < sizeUser; i++)
{
    Console.Write($"Введите {i+1} число: ");
    numbers [i] = Convert.ToInt32(Console.ReadLine());
    if (numbers [i]>0)
    {
        count++;
    }
}
Console.WriteLine($"Количество положительных чисел {count}");
Console.WriteLine($"Числа: [ {string.Join("; ", numbers)} ]");


// 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем