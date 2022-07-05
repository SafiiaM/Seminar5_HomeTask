// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
int sumNechet = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}

for (int n = 0; n < array.Length; n++)
{
    if (n % 2 == 1) sumNechet = sumNechet + array[n];
}


Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях -> {sumNechet}");

