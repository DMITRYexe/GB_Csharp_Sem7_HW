    // 75. Написать программу вычисления функции Аккермана - 5*
    int Acc(int m, int n)
    {
      if (m == 0) return n + 1;
      else if (m > 0 && n == 0) return Acc(m - 1, 1);
      else return Acc(m - 1, Acc(m, n - 1));
    }
    for (int m = 0; m < 4; m++)
    {
      for (int n = 0; n < 4; n++)
      {
        System.Console.WriteLine($"При {m},{n} = {Acc(m, n),-5}");
      }
    }