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
            string generated = inData.startWord;
            string word = inData.startWord;
            while (word != inData.endWord)
            {
                var stringBias = StringBias(inData, word);
                word = stringBias[r.Next(stringBias.Count)];
                generated += $" {word}";
            }
            return generated;
        }

        public static List<string> StringBias(ProcessResults inData, string word)
        {
            List<string> results = new List<string>();
            foreach (var step in inData.GetLinkFromWord(word).possibleSteps)
            {
                for (int i = 0; i < step.chance; i++)
                {
                    results.Add(step.word);
                }
            }
            return results;
        }
    }
}