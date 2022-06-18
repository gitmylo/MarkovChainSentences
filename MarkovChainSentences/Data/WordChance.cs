using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace MarkovChainSentences.Data
{
    [Serializable]
    public class WordChance
    {
        [JsonProperty("T")] public List<long> context;
        [JsonProperty("W")] public long word;
        //[JsonProperty("C")] public long chance = 0; // incremented by one every time this sequence is detected
    }

    [Serializable]
    public class WordLink
    {
        [JsonProperty("S")] public long source;
        [JsonProperty("PosSteps")] public List<WordChance> possibleSteps;
        public void incrementStep(long nextWord, List<long> context)
        {
            possibleSteps ??= new List<WordChance>();
            possibleSteps.Add(new WordChance()
            {
                //chance = 1,
                context = context,
                word = nextWord
            });
        }
    }
    
    [Serializable]
    public class TokenisedWord
    {
        public TokenisedWord(string word)
        {
            this.word = word;
            this.token = newest++;
        }
        public static long newest = 1;
        [JsonProperty("W")] public string word;
        [JsonProperty("T")] public long token;
    }
}