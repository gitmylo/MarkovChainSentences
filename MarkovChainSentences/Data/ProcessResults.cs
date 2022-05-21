using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace MarkovChainSentences.Data
{
    [Serializable]
    public class ProcessResults
    {
        public ProcessResults(){}
        public ProcessResults(List<WordLink> links) => this.links = links;
        [JsonProperty] public string startWord;
        [JsonProperty] public string endWord;
        [JsonProperty] public List<WordLink> links;

        public WordLink GetLinkFromWord(string word)
        {
            var array = links.Where(l => l.source == word).ToArray();
            if (array.Length == 0) return null;
            return array[0];
        }

        public WordLink GetLinkFromWordAndCreate(string word)
        {
            var array = links.Where(l => l.source == word).ToArray();
            if (array.Length == 0)
            {
                var newLink = new WordLink() {source = word};
                links.Add(newLink);
                return newLink;
            }
            return array[0];
        }
    }
}