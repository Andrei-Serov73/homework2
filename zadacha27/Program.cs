//Задача 27: Напишите метод, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

int summa(int A)
{
    int counter = Convert.ToString(A).Length;
    int num = 0;
    int res = 0;

  for(int i=0; i < counter; i++)
  {
    num = A - A % 10;
    res = res + (A - num);
    A = A / 10;
  }
    return res;
}
int sum = summa(A);
Console.WriteLine("Ответ: " +  sum);