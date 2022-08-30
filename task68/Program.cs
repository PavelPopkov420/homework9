int f(int m, int n)
{
    
  if (m == 0) 
    return n + 1;

  else if (n == 0) 
    return f(m - 1, 1);

  else
    return f(m - 1, f(m, n - 1));
}
Console.Write("Введи значение m : ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи значение n : ");
int n = Convert.ToInt16(Console.ReadLine());

Console.Write(f(m, n));