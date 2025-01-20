using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    public class Trie
    {
        public TrieNode Head;
        public Trie()
        {
            Head = new TrieNode(' ');
        }
        //public void Clear();

        public void Insert(string word)
        {
            TrieNode Current = Head;
            bool idk = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (Current.Children.ContainsKey(word[i]) && idk == true)
                {
                    Current = Current.Children[word[i]];
                }
                else
                {
                    idk = false;
                    Current.Children.Add(word[i], new TrieNode(word[i]));
                    Current = Current.Children[word[i]];
                }


            }
            Current.IsWord = true;


        }

        public bool Contains(string word)
        {
            if (SearchNode(word) != null) return true;
            return false;
        }

        private TrieNode SearchNode(string word)
        {
            TrieNode Current = Head;
            bool isInOtherWord = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (Current.Children.ContainsKey(word[i]) && isInOtherWord == true)
                {
                    Current = Current.Children[word[i]];
                }
                else
                {
                    return null;
                }




            }
            if (Current.IsWord == true) return Current;
            return null;
    

        }
        //public List<string> GetAllMatchingPrefix(string prefix);

        public bool Remove(string prefix)
        {
            TrieNode current = SearchNode(prefix);
            if (current == null) return false;
            current.IsWord = false;
            return true;

        }
    }


    
}
