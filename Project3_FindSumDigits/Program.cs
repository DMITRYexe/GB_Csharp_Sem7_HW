// 74. Найти сумму цифр числа
Console.WriteLine("Программа выводит сумму чисел введенного числа");
System.Console.Write("Задайте число. "); // по условию N надо задать 
int N = InputN();
  int sum=0;
System.Console.WriteLine(SumDigitsFromNumbers(N));



int InputN()
{
  int number = -1;
  bool ErrorStatus = false;
  do
  {
    System.Console.WriteLine("Введите целое число:");
    try
    {
      number = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      System.Console.WriteLine("Ошибка. Введите целое число");
      ErrorStatus = true;
    }
  } while (ErrorStatus==true);
  return number;
}


int SumDigitsFromNumbers (int num)
{
  if (num==0) 
  {
  return 0;
  }
  else 
  {
    return (SumDigitsFromNumbers(num/10)) + num%10;
  }
} 