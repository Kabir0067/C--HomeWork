


int EveCount(int n)
{
    int cnt = 0;
    for (int i = n; i > 0; i/=10)
    {
        if (i%2==0) cnt++;
    }
    return cnt;
}
int OddCount(int n)
{
    int odd = 0;
    for (int i = n; i > 0; i/=10)
    {
        if (i%2!=0) odd++;
    }
    return odd;
}

int DigitCount(int n)
{
    int digit = 0;
    for (int i = n; i > 0; i/=10)
    {
         digit++;
    }
    return digit;
}
int n=int.Parse(Console.ReadLine());
System.Console.WriteLine($"Even:{EveCount(n)}");
System.Console.WriteLine($"Odd:{OddCount(n)}");
System.Console.WriteLine($"Digit: {DigitCount(n)}");
