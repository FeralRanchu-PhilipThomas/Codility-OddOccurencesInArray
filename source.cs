using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        var @results = 0;

        if ((A.Min() >= 1 && A.Max() <= 1000000000) && (A.Count() >= 1 && A.Count() <= 1000000))
        {
            @results = A
                .GroupBy(n => n)
                .Where(g => g.Count() == 1)
                .Select(g => g.Key)
                .First();
        }

        return @results;
    }
}
