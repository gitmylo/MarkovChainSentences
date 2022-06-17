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
            results.startWord = results.getTokenFromNameOrCreate(split[0]).token;
            results.links = new List<WordLink>();
            string last = split[0];
            foreach (var s in split)
            {
                if (s == last) continue; // no support for that right now
                results.GetLinkFromWordAndCreate(
                        results.getTokenFromNameOrCreate(last)
                            .token
                        )
                    .incrementStep(
                        results.getTokenFromNameOrCreate(s)
                            .token
                        );
                last = s;
            }
            results.endWord = results.getTokenFromNameOrCreate(last).token;
            return results;
        }
    }
}