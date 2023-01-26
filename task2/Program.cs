// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int InputNumber(string str)
{
  int number;
  string text;
  while(true)
  {
    Console.WriteLine(str);
    text = Console.ReadLine();
    if(int.TryParse(text, out number))
    {
      break;
    }
    System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз.");
  }
  return number;
}

int[] IntToArray(int num, int arrayLenght)
{
  int[] array = new int[arrayLenght];
  int counter = arrayLenght - 1;
  while(num > 0)
  {
    array[counter] = num%10;
    num = num/10;
    counter--;
  }
  return array;
}

int SumArray(int[] array)
{
  int result = 0;
  for(int i = 0; i < array.Length; i++)
  {
    result = result + array[i];
  }
  return result;
}

int NumberInDigit(int num)
{
  int counter = 1;
  while(num>0)
  {
    num = num / 10;
    counter++;
  }
  return counter;
}

int a = InputNumber("Введите число: ");
int result = SumArray(IntToArray(a, NumberInDigit(a)));
System.Console.WriteLine("Сумма цифр числа " + a + " = " + result);
