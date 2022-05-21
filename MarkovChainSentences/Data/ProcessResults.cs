using System;
using Newtonsoft.Json;

namespace MarkovChainSentences.Data
{
    [Serializable]
    public class ProcessResults
    {
        public ProcessResults(){}
        public ProcessResults(WordLink[] links) => this.links = links;
        [JsonProperty] public WordLink[] links;
    }
}