using System;
using System.IO;
using System.Linq;
using MarkovChainSentences.Extensions;

namespace MarkovChainSentences
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Setup();
            string[] inFiles = stripPath(Directory.GetFiles(@"data\in"));
            string[] procFiles = stripPath(Directory.GetFiles(@"data\processed"));
            string[] outFiles = stripPath(Directory.GetFiles(@"data\out"));
            string[] notYetProc = inFiles.Except(procFiles).ToArray();
            string[] outCheck = procFiles.combine(notYetProc).Distinct().ToArray();
            string[] notYetOutPutted = outCheck.Except(outFiles).ToArray();
            
            
        }

        public static void Setup()
        {
            Directory.CreateDirectory(@"data/in");
            Directory.CreateDirectory(@"data/out");
            Directory.CreateDirectory(@"data/processed");
        }

        public static string[] stripPath(string[] files)
        {
            var outList = new string[files.Length].AsEnumerable();
            foreach (var f in files)
            {
                var split = f.Split('\\');
                var last = split.Length;
                var name = split[last - 1];
                if (name.Length >= 1)
                {
                    outList = outList.Append(name);
                }
            }
            return outList.ToArray();
        }
    }
}