using System;
class PrintNumbers
{
    // Write a program to print the numbers 1, 101 and 1001, each at a separate line.
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(Math.Pow(10, i));
            }
            else
            {
                Console.WriteLine("{0}{1}", Math.Pow(10, i), 1);
            }
        }
    }
}
