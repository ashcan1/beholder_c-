using System;

public class Exercise66
{
    public static void Main()
    {
        Console.Write("Enter the number of rows:\t");
        int num = int.Parse(Console.ReadLine());

        int t,b;
        
        for (t = 1; t <= num; t++)
        { Console.Write("*");
        }
        Console.WriteLine();



        for (int i = 1; i <= num - 2; i++)
        {
            bool isEven = num % 2 == 0;
            int starCount = isEven ? 2 : 1;
            
            for (int s = 1; s <= num - s; ++s)
            {
                Console.Write(" ");
            }


            for (int j = 1; j <= starCount; j++)
            {
                Console.Write("*");
        
            }
            

            Console.WriteLine();
        }
        
        
        
        for (b = 1; b <= num; b++)
        {
            Console.Write("*");
        }
    }
}
     