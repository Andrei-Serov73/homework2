//Задача 29: Напишите метод(ы), которай задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Write("Введите 8 чисел, разделенных запятой : ");
string? stroka = Console.ReadLine();

// функция удаления пробелов из строки 
string RemovingSpaces (string stroka1){
  string stroka2 = "";
  for (int i = 0; i < stroka1.Length; i++)
  {
    if (stroka1[i] != ' ') 
    {
      stroka2 += stroka1[i];
    }
  }
  return stroka2;
}

// функция  создания и заполнения массива из строки
int[] Array(string stroka2){ 

  int[] array = new int[1];    // инициализация массива из 1 элемента

  int j =0;

  for (int i = 0; i < stroka2.Length; i++){
    string seriesNew1 = "";

    while (stroka2[i] != ',' && i < stroka2.Length){
      seriesNew1 += stroka2[i];
      i++;
    }
    array[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < stroka2.Length-1){
      array = array.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return array;
}

// функция  вывода массива на печать 
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string stroka2 = RemovingSpaces(stroka);

int[] arrayOfNumbers =  Array(seriesNew);

PrintArry(array);

