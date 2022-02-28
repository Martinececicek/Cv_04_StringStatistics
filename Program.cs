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
                "Americký prezident Joe Biden dal jasně najevo, že nemá v úmyslu vyslat \n"
+ "americké vojáky do války s Ruskem, řekl podle agentury DPA Psakiová. \n"
+ "Bezletová zóna by podle ní byla krokem tímto směrem."
+ "Ukrajinský prezident Volodymyr Zelenskyj podle agentury Reuters řekl, že je "
+ "načase zvážit zavedení bezletové zóny pro ruské rakety, letadla a vrtulníky. Stát "
+ "by se tak podle něj mělo v reakci na ruské ostřelování města Charkov, kde "
+ "podle ukrajinských představitelů zahynulo 11 lidí a desítky dalších utrpěly "
+ "zranění.";
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
