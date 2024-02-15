int sum=1;
int a= int.Parse(Console.ReadLine());
int [] arr = new int[a];
for (int i = 0; i < a; i++)
{

  arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a-1; i++)
{
   sum*=arr[i];
   System.Console.Write(arr[i]);
   System.Console.Write("*"); 
}
  System.Console.Write(arr[a-1]);
  System.Console.Write("=");
  sum*=arr[a-1];
  System.Console.WriteLine(sum);
