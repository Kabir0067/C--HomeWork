﻿int MinNumber(int a,int b) 
{
    int min = 99999;
    if (a<b)
    {
        min = a;
    }else if(b<a)
    {
        min = b;
    }else
    
    return min;
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
System.Console.Write("Min num = ");
System.Console.Write(MinNumber(a,b));