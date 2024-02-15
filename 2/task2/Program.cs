int Add(int a,int b)
{
    return a + b;
}
int Subtract(int a,int b)
{
    return a - b;
}
int Multiply(int a,int b)
{
    return a * b;
}
int Division(int a,int b)
{
    return a / b;
}
int a = int.Parse(Console.ReadLine()),b = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Add: {Add(a,b)}");
System.Console.WriteLine($"Subtract: {Subtract(a,b)}");
System.Console.WriteLine($"Multiply: {Multiply(a,b)}");
System.Console.WriteLine($"Division: {Division(a,b)}");



