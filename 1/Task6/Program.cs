int a=int.Parse(Console.ReadLine());
int [] arr =new int [a];
for (int i = 0; i < a; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int c=0;
for (int i = 1; i < a-1; i++)
{
    if(arr[i]>arr[i+1] || arr[i]>arr[i-1])
    c++;
}
System.Console.WriteLine( );
System.Console.WriteLine(c);