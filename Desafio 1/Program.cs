using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(string[] arg)
    {
        var p = Console.ReadLine().ToLower();
        int n = p.Length;
        int alteracoes = 0;
        for (int i = 0; i < n / 2; i++)
        {
            if (p[i] == p[n - i - 1])
                continue;
            alteracoes += 1;
        }
        if (alteracoes == 0)
            Console.WriteLine("TRUE" + "" + " " + "-" + " " + alteracoes);
        else
            Console.WriteLine("FALSE" + "" + " " + "-" + " " + alteracoes);
    }
}