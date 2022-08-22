void Recursion_64(int m, int n)
{
    if (m % 3 == 0)
    {
        Console.WriteLine(m);
    }
    else if (m > n)
    {
        return;
    }
    m++;
    Recursion_64(m, n);
}

//Recursion_64(1, 9);


void Recursion_66(int m, int n, int sum = 0)
{
    if (m == n + 1)
    {
        Console.WriteLine(sum);
        return;
    }
    sum += m;
    m++;
    Recursion_66(m, n, sum);
}

//Recursion_66(1, 5);


int Recursion_68(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (n == 0)
    {
        return Recursion_68(m - 1, 1);
    }
    else
    {
        return Recursion_68(m - 1, Recursion_68(m, n - 1));
    }
}

void Zadacha_68()
{
    Console.WriteLine("Введите число m =");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n =");
    int n = Convert.ToInt32(Console.ReadLine());
    int f = Recursion_68(m, n);
    Console.WriteLine($"Результат функции Аккермана = {f}");
}
Zadacha_68();