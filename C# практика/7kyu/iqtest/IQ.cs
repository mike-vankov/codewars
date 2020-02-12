using System;
using System.Linq;

public class IQ
    {
        public static int Test(string numbers)
        { 
             return numbers.Split(' ')
            .Select((v, i) => new { numbers = v, index = i })
            .GroupBy(g => Convert.ToInt32(g.numbers) % 2)
            .First(w => w.Count() == 1)
            .Select(s => s.index).First() + 1;
        }
    }