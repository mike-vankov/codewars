using System;
using System.Linq;

namespace Tile_Case
{
    public class Kata
    {
        public static string TitleCase(string title, string minorWords = "")
        {
            var TitleWords = title.Split(' ');
            if (minorWords == null)
                return string.Join(' ', TitleWords.Select(c =>new string(Enumerable.Range(0, c.Length).Select(i => i == 0 ? char.ToUpper(c[i]) :char.ToLower(c[i])).ToArray())));
            
            var NormalWords=TitleWords.Select(c => !minorWords.ToLowerInvariant().Split(' ').Contains(c.ToLowerInvariant()) ? new string(Enumerable.Range(0, c.Length).Select(i => i == 0 ? char.ToUpper(c[i]) :char.ToLower(c[i])).ToArray()) : c.ToLowerInvariant()).ToList();
            var NormalFirstWord=new string(Enumerable.Range(0, NormalWords.ElementAt(0).Length).Select(i => i == 0 ? char.ToUpper(NormalWords.ElementAt(0)[i]) : char.ToLower(NormalWords.ElementAt(0)[i])).ToArray());
            NormalWords.RemoveAt(0);
            NormalWords.Insert(0, NormalFirstWord);
            return string.Join(' ', NormalWords);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.TitleCase("THE WIND IN THE WILLOWS", "The In"));
            Console.ReadLine();
        }
    }
}
