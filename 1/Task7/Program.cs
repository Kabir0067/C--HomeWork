int a= int.Parse(Console.ReadLine());
int [] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int b = 0 , c=0;
for (int i = 1; i < a - 1; i++)
{
    if ((arr[i] > 0 && arr[i +1] > 0) || (arr[i] < 0 && arr[i+1] < 0 ))
    {
        b = arr[i+1];
        c = arr[i];
    }
}
System.Console.WriteLine($"{b} {c}");