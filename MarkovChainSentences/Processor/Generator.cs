using System;
using System.Collections.Generic;
using System.Linq;
using MarkovChainSentences.Data;

namespace MarkovChainSentences.Processor
{
    public class Generator
    {
        public static string Generate(ProcessResults inData)
        {
            Random r = new Random();
            string generated = inData.getTokenFromToken(inData.startWord).word;
            var splitList = generated.Split(' ');
            string word = splitList[splitList.Length-1];
            List<long> past = new List<long>();
            foreach (var splitString in splitList) 
                past.Add(inData.getTokenFromNameOrCreate(splitString).token);
            while (past.Count > inData.depth) past.RemoveAt(0);
            
            var endToken = inData.getTokenFromToken(inData.endWord).word;
            while (word != endToken)
            {
                var stringBias = StringBias(inData, word, past);
                var wordToken = inData.getTokenFromToken(stringBias[r.Next(stringBias.Count)]);
                word = wordToken.word;
                
                past.Add(wordToken.token);
                if (past.Count > inData.depth)
                {
                    past.RemoveAt(0);
                }
                
                generated += $" {word}";
            }
            return generated;
        }

        /*public static List<long> StringBias(ProcessResults inData, string word)
        {
            List<long> results = new List<long>();
            WordLink link = inData.GetLinkFromWord(
                    inData.getTokenFromNameOrCreate(word)
                        .token
                );
            if (link != null)
            {
                foreach (var step in link.possibleSteps)
                {
                    for (int i = 0; i < step.chance; i++)
                    {
                        results.Add(step.word);
                    }
                }
            }
            else
            {
                results.Add(inData.endWord);
            }
            
            return results;
        }*/

        public static List<long> StringBias(ProcessResults inData, string word, List<long> context)
        {
            long thisWordToken = inData.getTokenFromNameOrCreate(word).token;
            Dictionary<long, long> results = new Dictionary<long, long>();
            WordLink link = inData.GetLinkFromWordAndCreate(thisWordToken);
            foreach (var chance in link.possibleSteps)
            {
                var c = (context.Intersect(chance.context).Count()) * 50;
                if (!results.ContainsKey(chance.word))
                {
                    results.Add(chance.word, c);
                }
                else
                {
                    results[chance.word] += c;
                }
            }
            List<long> total = new List<long>();
            foreach (var result in results)
            {
                for (int i = 0; i < result.Value; i++)
                {
                    total.Add(result.Key);
                }
            }

            if (total.Count == 0)
            {
                //add a random result from results to total
                total.Add(results.ElementAt(new Random().Next(results.Count)).Key);
            }

            return total;
        }
    }
}