

int a= int.Parse(Console.ReadLine());
int [] arr = new int[a];
for (int i = 0; i < a; i++)
{

  arr[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(arr);
System.Console.WriteLine(a-1);