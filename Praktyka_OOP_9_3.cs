using System;

class Praktyka_OOP_9_3
{
    static void Main()
    {
        string s =
            "Broken bottomless bottles";

        string[] a;

        a = s.Split(' ');

        string glasni =
            "aeiouy";

        string word = "";

        int max = 0;

        for (int i = 0;
             i < a.Length;
             i++)
        {
            int k = 0;

            for (int j = 0;
                 j < a[i].Length;
                 j++)
            {
                if (glasni.IndexOf(a[i][j])
                    != -1)
                {
                    k++;
                }
            }

            if (k > max)
            {
                max = k;
                word = a[i];
            }
        }

        Console.WriteLine(word);

        Console.ReadKey();
    }
}