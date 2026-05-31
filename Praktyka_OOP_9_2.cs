using System;

class Praktyka_OOP_9_2
{
    static void Main()
    {
        string s = "абвабвабвбав";

        for (int i = s.Length - 3; i > 0; i -= 3)
        {
            s = s.Insert(i, " ");
        }

        Console.WriteLine(s);

        Console.ReadKey();
    }
}