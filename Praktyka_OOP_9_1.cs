using System;

class Praktyka_OOP_9_1
{
    static void Main()
    {
        string s = "ввддддддддддддддііісссссссс";

        int max = 1;
        int k = 1;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                k++;

                if (k > max)
                    max = k;
            }
            else
            {
                k = 1;
            }
        }

        Console.WriteLine(max);
        Console.ReadKey();
    }
}