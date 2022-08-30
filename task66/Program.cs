int f(int n, int m)
{
    if (m == 0) 
        return 0;
    return f(n, m-1) + m;
}
Console.Write("Введи значение от: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи значение до: ");
int m = Convert.ToInt16(Console.ReadLine());

Console.Write("Cумму натуральных элементов: " + f(n, m));