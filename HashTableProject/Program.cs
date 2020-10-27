using System;
using System.Collections.Generic;

namespace HashTableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, int> occurrences = new MyMapNode<string, int>(1);
            string input = "to be or not to be";
            string[] words = input.Split(null);
            foreach (String word in words)
            {
                int oldCount = occurrences.Get(word);
                if(oldCount!=0)
                {
                    occurrences.Remove(word);
                }
                occurrences.Add(word, oldCount + 1);
            }
            foreach (String word in words)
            {
                Console.WriteLine(word + " : " + occurrences.Get(word));
            }
        }
    }
}
