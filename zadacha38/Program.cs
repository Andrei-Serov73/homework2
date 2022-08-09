//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Введите кол-во элементов массива");
int A = Convert.ToInt32 (Console.ReadLine());
//Console.WriteLine("Введите минимальный элемент массива");
//double B = Convert.ToInt32 (Console.ReadLine());
//Console.WriteLine("Введите максимальный элемент массива");
//double C = Convert.ToInt32 (Console.ReadLine());
double[] array = new double[A];

void ArrayFill (double[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(-10, 100);
    }
}
void ArrayPrint (double[] array)
{
    for(int j = 0; j < array.Length; j ++)
    {
        Console.Write($"{array[j]},");
    }
}
ArrayFill(array);
double min = 0;
{
    for (int z = 0; z < array.Length; z++)
    if (array[z] < min) min = array[z];
}
double max = 0;
{
    for (int y = 0; y < array.Length; y++)
    if (array[y] > max) max = array[y];
}
double x = max - min;

//Console.WriteLine($"{min}" );
//Console.WriteLine($"{max}");
Console.Write($"[");
ArrayPrint(array);
Console.Write($"]-> {x} ");