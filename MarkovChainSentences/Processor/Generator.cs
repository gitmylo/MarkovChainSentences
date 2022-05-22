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
            var splitList = inData.startWord.Split(' ');
            string word = splitList[splitList.Length-1];
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
            WordLink link = inData.GetLinkFromWord(word);
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