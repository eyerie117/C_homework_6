// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// Console.Clear();
// Console.WriteLine("Введите числа через пробел: ");
// int[] arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Console.WriteLine($"[{string.Join(", ", arr)}]");

// int FindPositive(int[] array)
// {
//     int n = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             n++;
//     }
//     return n;
// }

// Console.WriteLine(FindPositive(arr));

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите числа b1, k1, b2, k2 через пробел: ");
int[] arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

void FindIntersection(int[] array)
{
    double b1 = array[0]; //2
    double k1 = array[1]; //5
    double b2 = array[2]; //4
    double k2 = array[3]; //9

    double x = (b2 - b1) / (k1 - k2); //(4 - 2) / (5 - 9)
    double y = k1 * x + b1; //5 * (-0.5) + 2

    Console.WriteLine($"[{x}; {y}]");
}

FindIntersection(arr);
