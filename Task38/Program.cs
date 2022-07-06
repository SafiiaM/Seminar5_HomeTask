// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
int [] array = {3,7,22,2,78};
int max = array[0];
int min = array[0];

for (int a = 0; a < array.Length; a++)

{
    if (array[a] > max) max = array[a];
    if (array[a] < min) min = array[a];
    }

Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом равна -> ");
Console.Write(max - min);