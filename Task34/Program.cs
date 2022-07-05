// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[4];
int countChet = 0;


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int k = 0; k < array.Length; k++)
{
    if (array[k] % 2 == 0) countChet = countChet + 1;
    
}
Console.Write("Количество четных чисел в массиве -> " + countChet);
Console.WriteLine();
