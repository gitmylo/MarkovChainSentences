using System;
using System.IO;
using System.Linq;

namespace MarkovChainSentences
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Setup();
            string[] inFiles = Directory.GetFiles(@"data/in");
            string[] procFiles = Directory.GetFiles(@"data/out");
            string[] outFiles = Directory.GetFiles(@"data/processed");
            
        }

        public static void Setup()
        {
            Directory.CreateDirectory(@"data/in");
            Directory.CreateDirectory(@"data/out");
            Directory.CreateDirectory(@"data/processed");
        }
    }
}