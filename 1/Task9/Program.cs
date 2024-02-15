int n = int.Parse(Console.ReadLine());
int [] arr = new int [n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
for (int i = a; i < b; i++)
{
    if (arr[i]%2!=0)System.Console.WriteLine($"{arr[i]}");
    
}