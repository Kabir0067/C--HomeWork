int MaxNumber(int a,int b) 
{
    int max = -99999;
    if (a>b)
    {
        max = a;
    }else if(b>a)
    {
        max = b;
    }
    
    return max;
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
System.Console.Write("Max num = ");
System.Console.Write(MaxNumber(a,b));