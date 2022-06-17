﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace MarkovChainSentences.Data
{
    [Serializable]
    public class WordChance
    {
        [JsonProperty("W")] public long word;
        [JsonProperty("C")] public long chance = 0; // incremented by one every time this sequence is detected
    }

    [Serializable]
    public class WordLink
    {
        [JsonProperty("S")] public long source;
        [JsonProperty("PosSteps")] public List<WordChance> possibleSteps;
        public void incrementStep(long nextWord)
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