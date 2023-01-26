// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] FillArray()
{
  Random rand = new Random();
  int[] array = new int[8];
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = rand.Next(0, 101);
  }
  return array;
}

void ShowArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    System.Console.Write(array[i] + " ");
  }
}

ShowArray(FillArray());