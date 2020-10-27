using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, int> occurrences = new MyMapNode<string, int>(1);
            string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
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
            string[] repeat=new string[50];int index = -1;
            foreach (String word in words)
            {
                if(!repeat.Contains(word))
                {
                    Console.WriteLine(word + " : " + occurrences.Get(word));
                }
                if (occurrences.Get(word)>1)
                {
                    repeat[++index] = word;
                }
            }
        }
    }
}
