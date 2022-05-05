using System;
using Generic_Simple;

public class Program
{
    public static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
        char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
        //Program.toPrint(intArray);
        //Program.toPrint(doubleArray);
        //Program.toPrint(charArray);

        Generic1.toPrint<int>(intArray);
        Generic1.toPrint<double>(doubleArray);
        Generic1.toPrint<char>(charArray);
        Console.ReadKey();
    }
}
