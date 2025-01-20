using System.Diagnostics.Tracing;

namespace Tries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();

            string filePath = "C:\\Users\\shahv\\source\\repos\\Tries\\fulldictionary (1).json";
            foreach (string line in File.ReadLines(filePath))
            {
               // Console.WriteLine(line);
                int index = line.IndexOf(":");
                if (index != -1)
                {

                    string word = line.Substring(3, index - 4);
                    Console.WriteLine(word);
                    trie.Insert(word);
                    ;
                }
            }

            Console.WriteLine(trie.Contains("asdf;lkj"));
           // List<string> words = trie.GetAllMatchingPrefix("");
            //foreach(string word in words) { Console.WriteLine(word); }
            ;
        }
    }
}
