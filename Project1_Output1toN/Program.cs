// 70. Показать натуральные числа от 1 до N, N задано.


Console.WriteLine("Программа выводит числа от 1 до N");
System.Console.Write("Задайте N. "); // по условию N надо задать 
int N = InputN();
int i = 0;
Output1toN(N, i);






int InputN()
{
  int N = -1;
  do
  {
    System.Console.WriteLine("Введите натуральное число:");
    try
    {
      N = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      System.Console.WriteLine("Ошибка. Введите натуральное число");
    }
  } while (N < 1);
  return N;
}

void Output1toN(int N, int i)
{
  System.Console.Write($"{++i}  ");
  if (i < N)
    Output1toN(N, i);
}