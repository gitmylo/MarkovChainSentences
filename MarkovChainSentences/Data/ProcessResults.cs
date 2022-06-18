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
        [JsonProperty("Depth")] public int depth;
        [JsonProperty("Words")] public List<TokenisedWord> words;
        [JsonProperty("SWord")] public long startWord;
        [JsonProperty("EWord")] public long endWord;
        [JsonProperty("Links")] public List<WordLink> links;

        public TokenisedWord getTokenFromNameOrCreate(string word)
        {
            words = words ?? new List<TokenisedWord>();
            word = word.ToLower();
            var token = words.FirstOrDefault(x => x.word == word);
            if (token == null)
            {
                token = new TokenisedWord(word);
                words.Add(token);
            }
            return token;
        }

        public TokenisedWord getTokenFromToken(long token)
        {
            return words.FirstOrDefault(x => x.token == token);
        }

        public WordLink GetLinkFromWord(long word)
        {
            var array = links.Where(l => l.source == word).ToArray();
            if (array.Length == 0) return null;
            return array[0];
        }

        public WordLink GetLinkFromWordAndCreate(long word)
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