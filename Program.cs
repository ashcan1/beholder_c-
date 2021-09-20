using System;  
public class Exercise66
{  
    public static void Main()
    {
        Console.Write("Enter the number of rows:\t");
        int num = int.Parse(Console.ReadLine());
        int row,column; 

 
        for(row=0;row<=num;row++)
        {
            for (column=0; column<=num; column++)
            {
                if (column == num|| (row == 0 && column > 0 && column < num) || (row == num && column > 0 && column < num))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
                
           
            
            Console.Write("\n");
        }
        Console.Write("\n");
    }
}