using System;  
public class Exercise66
{  
    public static void Main()
    {
        int row,column; 

 
        for(row=0;row<=6;row++)
        {
            for (column=0; column<=6; column++)
            {
                if (column == 3|| (row == 0 && column > 0 && column < 6) || (row == 6 && column > 0 && column < 6))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
                
           
            
            Console.Write("\n");
        }
        Console.Write("\n");
    }
}