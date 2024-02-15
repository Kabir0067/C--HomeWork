int MinNumber(int a,int b,int c,int d)
{
    int min = 99999;
    if (a<b && a<c & a<d)
    {
        min = a;
    }else if(b<a && b < c && b < d)
    {
        min = b;
    }else if(c<a && c < b&& c < d)
    {
        min = c;
    }else if(d < a && d<b && d<c)
    {
        min = d;
    }
    return min;
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
System.Console.Write("Min num: ");
System.Console.Write(MinNumber(a,b,c,d));