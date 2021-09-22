using System;

public class Exercise66
{
    public static void Main()
    {
        Console.Write("Enter the number of rows:\t");
        int num = int.Parse(Console.ReadLine());

        int t, m, b, s, e;
        for (t = 1; t <= num; ++t)
        {
            Console.Write("* ");
        }
        Console.WriteLine();



        for (m = 1; m <= num / 2; ++m)
        {
      

            if (num % 2 == 0)
            { 
                Console.WriteLine("* ");
            }
            else
            {
                {
                    for (s = 1; s <= num; s++)
                    {
                        Console.Write(" ");
                    }

                    for (s = 1; s <= m; ++s)
                    {
                        Console.Write("*");
                    }
                }
            }







            Console.WriteLine();
        }
        
        for (b = 1; b <= num; ++b)
        {
            Console.Write("* ");
        }
    }
}
     