// 78. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
// Принять первые числа равными 0 и 1. Использовать рекурсию.

System.Console.WriteLine("Программа выводит заданое кол-во чисел вибоначи");
System.Console.WriteLine("Введите требуемое кол-во чисел Фибоначчи:");
int N = InputN();
System.Console.Write("Числа Фибоначчи: ");
OutputFib(N);




int InputN()
{
  int number = -1;
  bool ErrorStatus = false;
  do
  {
    ErrorStatus = false;
    System.Console.WriteLine("Введите натуральное число:");
    try
    {
      number = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      System.Console.WriteLine("Ошибка. Введите натуральное число");
      ErrorStatus = true;
    }
    if (number < 1) ErrorStatus = true;
  } while (ErrorStatus == true);
  return number;
}

int Fib(int N) // где N - порядковый номер конечного числа Фибоначи
{
  if (N == 1) return 0;
  else if (N < 1) return -1;
  else if (N == 2) return 1;
  else if (N == 3) return 1;
  else return Fib(N - 1) + Fib(N - 2);
}

void OutputFib (int N)
{
  for (int i=1; i<N+1; i++)
  System.Console.Write($"{Fib(i)}  ");
}