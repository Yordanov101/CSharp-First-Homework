using System;
class PrintLongSequence
{
    static void Main()
    {
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 1 == 0)
            {
                Console.Write("{0},", i);
            }
            
        }
        Console.WriteLine();
    }
}