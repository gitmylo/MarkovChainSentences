using System;
using Newtonsoft.Json;

namespace MarkovChainSentences.Data
{
    [Serializable]
    public class WordChance
    {
        [JsonProperty] public string word;
        [JsonProperty] public float chance;
    }

    [Serializable]
    public class WordLink
    {
        [JsonProperty] public string source;
        [JsonProperty] public WordChance[] possibleSteps;
    }
}