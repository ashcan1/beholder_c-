using System;

public class Exercise66
{
    public static void Main()
    {
        Console.Write("Enter the number of rows:\t");
        int num = int.Parse(Console.ReadLine());

        int t, m, b;
        for (t = 1; t <= num; ++t)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
        
        for (m = 1; m <= num; ++m )
        {
            Console.Write("* *");
            Console.WriteLine();
         
            
            
        }


        Console.WriteLine();
        for (b = 1; b <= num; ++b)
        {
            Console.Write("* ");
        }
    }
}
     