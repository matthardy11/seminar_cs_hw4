// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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

int DegreeOfNumber(int a, int b)
{
int result = a;
for(int i = 1; i < b; i++)
  {
    result = result*a;
  }
return result;
}

int num1 = InputNumber("Введите число А: ");
int num2 = InputNumber("Введите число B: ");

System.Console.WriteLine("Число " + num1 + " в степени " + num2 + " = " + DegreeOfNumber(num1, num2));
