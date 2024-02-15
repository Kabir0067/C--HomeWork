using System;

static int Pow(int x, int y)
{
    int result = 1;
    
    for (int i = 0; i < y; i++)
    {
        result *= x;
    }
    
    return result;
}


    int x = int.Parse(Console.ReadLine());
    
    int y = int.Parse(Console.ReadLine());
    
    int result = Pow(x, y);
    
    Console.WriteLine($"x = {x} \ny = {y} \n{result}");

