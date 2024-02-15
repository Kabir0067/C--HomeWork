int n = int.Parse(Console.ReadLine());
int [] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine();

for (int i = 0; i < n; i++)
{
    if(arr[i]%2!=0)System.Console.WriteLine(i);
}