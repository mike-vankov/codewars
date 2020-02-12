using System;
using System.Linq;

public class Revrot 
{
      public static string RevRot(string strng, int sz)
        {
            if (String.IsNullOrEmpty(strng) || sz <= 0 || sz > strng.Length)
                return String.Empty;
            return new string(
            Enumerable.Range(0, strng.Length / sz).Select(
                i => strng.Substring(i * sz, sz)).Select(
                    chunk => chunk.Sum(ch => (int)Math.Pow(Int32.Parse(ch.ToString()), 3)) % 2 == 0 ? chunk.Reverse() :
            chunk.Skip(1).Concat(chunk.Take(1))).SelectMany(x => x).ToArray()
          );
        }
}