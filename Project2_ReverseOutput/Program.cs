// 71. Показать натуральные числа от N до 1, N задано.
Console.WriteLine("Программа выводит числа от N до 1");
System.Console.Write("Задайте N. "); // по условию N надо задать 
int N = InputN();
int i = 1;
if (N!=1)
{
System.Console.Write($"{N}  ");
OutputNto1(N, i);
}
else 
System.Console.WriteLine(N);



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

void OutputNto1(int N, int i)
{
  System.Console.Write($"{--N}  ");
  if (i < N)
    OutputNto1(N, i);
}