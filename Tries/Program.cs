namespace Tries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Trie trie = new Trie();
            trie.Insert("Hello");
            trie.Insert("Happy");
            trie.Insert("Apple");
            trie.Insert("Apple");
            trie.Insert("App");
            trie.Insert("Happiness");
            trie.Remove("App");
            Console.WriteLine(trie.Contains("App"));
            ;
        }
    }
}
