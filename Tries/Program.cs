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
                    //Console.WriteLine(word);
                    trie.Insert(word);
                    ;
                }
            }
            


            Console.WriteLine("Type something and i will give definition:");
            string prefix = Console.ReadLine();
            List<string> words = trie.GetAllMatchingPrefix(prefix);
            if (trie.Contains(prefix))
            {
                foreach(string line in File.ReadLines(filePath))
                {
                    int index = line.IndexOf(":");

                    if (line.Contains(prefix))
                    {
                        Console.WriteLine(line.Substring(index + 2), line.Length - 2);
                    }
                }
            }
            else
            {
                Console.WriteLine("Did you mean:");
                foreach (string word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }


           // List<string> words = trie.GetAllMatchingPrefix("");
            //foreach(string word in words) { Console.WriteLine(word); }
            ;
        }
    }
}
