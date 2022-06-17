using System;
using System.Collections.Generic;
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
            while (word != inData.getTokenFromToken(inData.endWord).word)
            {
                var stringBias = StringBias(inData, word);
                word = inData.getTokenFromToken(stringBias[r.Next(stringBias.Count)]).word;
                generated += $" {word}";
            }
            return generated;
        }

        public static List<long> StringBias(ProcessResults inData, string word)
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
        }
    }
}