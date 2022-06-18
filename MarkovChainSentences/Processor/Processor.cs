using System.Collections.Generic;
using MarkovChainSentences.Data;

namespace MarkovChainSentences.Processor
{
    public class Processor
    {
        const int ContextDepth = 3;
        public static ProcessResults Process(string data, int depth = ContextDepth)
        {
            var split = data.Split(' ');
            ProcessResults results = new ProcessResults();
            TokenisedWord.newest = 1;
            results.depth = depth;
            results.startWord = results.getTokenFromNameOrCreate(split[0]).token;
            results.links = new List<WordLink>();
            List<long> context = new List<long>();
            long last = results.getTokenFromNameOrCreate(split[0]).token;
            foreach (var s in split)
            {
                long token = results.getTokenFromNameOrCreate(s).token;
                if (token == last) continue; // no support for that right now
                results.GetLinkFromWordAndCreate(
                        last
                        )
                    .incrementStep(
                        results.getTokenFromNameOrCreate(s)
                            .token,
                        //clone context
                        new List<long>(context)
                        );
                context.Add(token);
                if (context.Count > depth)
                {
                    context.RemoveAt(0);
                }
                last = token;
            }
            results.endWord = last;
            return results;
        }
    }
}