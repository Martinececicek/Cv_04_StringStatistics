using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv_04_StringStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string testText =
                "Toto je retezec predstavovany nekolika radky,\n"
                + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                + "posledni veta!";
            //testText = "Pico! necum nebo? ti dam jebu";
            StringStatistics s = new StringStatistics(testText);
            Console.WriteLine("HIHIHIHI");
            Console.WriteLine("Number of words: {0}", s.NumberOfWords());
            Console.WriteLine("Number of rows: {0}", s.NumberOfRows());
            Console.WriteLine("Number of sentences: {0}", s.NumberOfSentences());
            Console.WriteLine("Longest words: {0}", s.PrintList(s.LongestWords()));
            Console.WriteLine("Shortest words: {0}", s.PrintList(s.ShortestsWords()));
            Console.WriteLine("Most common words: {0}", s.PrintList(s.MostCommon()));
            Console.WriteLine("Sorted words: {0}", s.PrintList(s.Sorted()));
            Console.ReadLine();
        }
    }
}
