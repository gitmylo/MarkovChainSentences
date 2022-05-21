using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace MarkovChainSentences.Data
{
    [Serializable]
    public class WordChance
    {
        [JsonProperty] public string word;
        [JsonProperty] public int chance = 0; // incremented by one every time this sequence is detected
    }

    [Serializable]
    public class WordLink
    {
        [JsonProperty] public string source;
        [JsonProperty] public List<WordChance> possibleSteps;
        public void incrementStep(string nextWord)
        {
            possibleSteps ??= new List<WordChance>();
            var array = possibleSteps.Where(l => l.word == nextWord).ToArray();
            if (array.Length == 0)
            {
                possibleSteps.Add(
                    new WordChance()
                    {
                        chance = 1,
                        word = nextWord
                    }
                );
            }
            else array[0].chance++;
        }
    }
}