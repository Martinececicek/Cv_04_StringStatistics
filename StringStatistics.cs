using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv_04_StringStatistics
{
    public class StringStatistics
    {
        public string Text { get; set; }

        public StringStatistics(string text)
        {
            this.Text = text;
        }   

        public int NumberOfWords() //Returns number of words split by ' ' and new line
        {
            List<string> words = new List<string>(ZpracovanyString());
            int numofwords = words.Count;
            return numofwords;
        }

        public int NumberOfRows() //Returns number of rows (\n == new line)
        {
            char[] delim = { '\n' };
            int numofrows = Text.Split(delim).Length;
            return numofrows;
        }

        public int NumberOfSentences()
        {
            char[] delim = { '.' , '!' , '?'};
            string text = Text.Replace("\n", "");
            text = text.Replace(" ", "");
            string[] rows = text.Split(delim);
            
            int count = 0;

            for (int i = 0; i < rows.Length-1; i++)
            {
                if (Char.IsUpper(rows[i][0]))
                {
                    count++;
                }
            }

            return count;
        }

        public List<string> LongestWords() //hledame nejdelsi slova
        {
            List<string> longestwords = new List<string>();
            List<string> words = new List<string>(ZpracovanyString());
            int biggest = 0;

            foreach (var word in words)
            {
                if (word.Length > biggest)
                {
                    biggest = word.Length;
                    longestwords.Clear();
                    longestwords.Add(word);
                }
                else if (word.Length == biggest)
                {
                    if (longestwords.Contains(word) == false) //at zbytecne nevypisujeme ty same slova, staci jednou
                    {
                        longestwords.Add(word);
                    }
                }
            }
            
            return longestwords;
        }

        public List<string> ShortestsWords() //hledame nejkratsi slova
        {
            List<string> shortestwords = new List<string>();
            List<string> words = new List<string>(ZpracovanyString());


            int shortest = int.MaxValue;
            foreach (var word in words)
            {
                if ((word.Length < shortest) && (word != ""))
                {
                    shortest = word.Length;
                    shortestwords.Clear();
                    shortestwords.Add(word);
                }
                else if (word.Length == shortest)
                {
                    if (shortestwords.Contains(word) == false) //at zbytecne nevypisujeme ty same slova, staci jednou
                    {
                        shortestwords.Add(word);
                    }
                }
            }
            return shortestwords;
        }

        public List<string> MostCommon()
        {
            var dict = new Dictionary<string, int>();
            List<string> commWords = new List<string>();
            List<string> words = new List<string>(ZpracovanyString());

            int count = 0;

            foreach (var item in words)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            foreach (var key in dict)
            {
                if (key.Value > count)
                {
                    count = key.Value;
                    commWords.Clear();
                    commWords.Add(key.Key);
                }
                else if (key.Value == count)
                {
                    commWords.Add(key.Key);
                }
                
            }
            return commWords;
        }

        public List<string> Sorted()
        {
            List<string> words = new List<string>(ZpracovanyString());
            words.Sort();
            return words;
        }

        private List<string> ZpracovanyString() //vrati ze stringu List se vsemi slovy z celeho textu
        {
            List<string> commWords = new List<string>();

            string text = Text.Replace("\n", " ");

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]) == false)
                {
                    text = text.Insert(i, " ");
                    text = text.Remove(i + 1, 1);
                }
                if (i != (text.Length - 1))
                {
                    if (Char.IsWhiteSpace(text[i]) && Char.IsWhiteSpace(text[i + 1]))
                    {
                        text = text.Remove(i + 1, 1);
                    }

                }

            }

            string[] wordiky = text.Split(' '); //pouze pomocna
            List<string> words = new List<string>(); //     vsechno naplnujeme do listu protoze
            for (int i = 0; i < wordiky.Length; i++) //     je snim jednodussi prace
            {
                words.Add(wordiky[i]);
                words.Remove("");
            }

           

            return words;
        }

        public StringBuilder PrintList(List<string> list)
        {
            StringBuilder text = new StringBuilder();
            if (list.Count == 1)
            {
                text.Append(list[0]);
            }
            else
            {
                foreach (var item in list)
                {
                    text.Append(item).Append(", ");
                }
            }
            return text;
        }

        public override string ToString()
        {
            return this.Text;
        }


    }
}
