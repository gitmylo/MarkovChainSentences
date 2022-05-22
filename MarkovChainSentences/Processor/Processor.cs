using System.Collections.Generic;
using MarkovChainSentences.Data;

namespace MarkovChainSentences.Processor
{
    public class Processor
    {
        public static ProcessResults Process(string data)
        {
            var split = data.Split(' ');
            ProcessResults results = new ProcessResults();
            results.startWord = split[0];
            results.links = new List<WordLink>();
            string last = split[0];
            foreach (var s in split)
            {
                if (s == last) continue; // no support for that right now
                results.GetLinkFromWordAndCreate(last.ToLower()).incrementStep(s);
                last = s;
            }
            results.endWord = last;
            return results;
        }
    }
}