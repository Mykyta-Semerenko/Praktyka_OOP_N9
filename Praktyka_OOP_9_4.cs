using System;

class Praktyka_OOP_9_4
{
    static void Main()
    {
        string s =
            "free food is a trap food";

        string[] a;

        a = s.Split(' ');

        string result = "";

        for (int i = 0;
             i < a.Length;
             i++)
        {
            int k = 0;

            for (int j = 0;
                 j < a.Length;
                 j++)
            {
                if (a[i] == a[j])
                    k++;
            }

            if (k == 1)
            {
                result =
                    result +
                    a[i] +
                    " ";
            }
        }

        Console.WriteLine(result);

        Console.ReadKey();
    }
}