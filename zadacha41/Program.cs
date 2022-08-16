// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например : 0, 7, 8, -2, -2 -> 2
//            1, -7, 567, 89, 223-> 3

// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write($"Введи число М(количество чисел в строке): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void Numbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int sum(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

Numbers(m);
void ArrayPrint (int[] massiveNumbers)
{
    for(int j = 0; j < massiveNumbers.Length; j ++)
    {
        Console.Write($"{massiveNumbers[j]},");
    }
}
Console.Clear();
ArrayPrint(massiveNumbers);

Console.WriteLine($"-> {sum(massiveNumbers)} ");