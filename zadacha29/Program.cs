//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//например [345, 897, 568, 234] -> 2

int[] array = new int[9];

void ArrayFill (int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void ArrayPrint (int[] array)
{
    for (int j =0; j < array.Length; j++)
    {
        Console.Write($" {array[j]}, ");
    }
}
ArrayFill(array);
int a = 0;
{
    for (int z = 0; z < array.Length; z++)
    if (array[z] % 2 == 0) a++;
}
Console.Write($"[");
ArrayPrint(array);
Console.Write($"]");
Console.Write($" -> {a} ");