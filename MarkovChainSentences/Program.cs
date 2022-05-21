using System;
using System.IO;
using System.Linq;
using MarkovChainSentences.Data;
using MarkovChainSentences.Extensions;
using MarkovChainSentences.Processor;
using Newtonsoft.Json;

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
            string[] notYetProc = inFiles.Except(procFiles).Where(i => i != null).ToArray();
            string[] outCheck = procFiles.combine(notYetProc).Distinct().Where(i => i != null).ToArray();
            string[] notYetOutPutted = outCheck.Except(outFiles).Where(i => i != null).ToArray();

            Console.WriteLine("Starting processing...");
            foreach (var p in notYetProc)
            {
                var path = $@"data\in\{p}";
                var outPath = $@"data\processed\{p}";
                Console.WriteLine($"Now processing {p}");
                if (!File.Exists(path))
                {
                    Console.WriteLine("Failed, file does not exist!");
                    continue;
                }
                var results = Processor.Processor.Process(File.ReadAllText(path));
                File.WriteAllText(outPath, JsonConvert.SerializeObject(results));
            }
            Console.WriteLine("Done processing, now generating!");
            foreach (var p in notYetOutPutted)
            {
                var path = $@"data\processed\{p}";
                var outPath = $@"data\out\{p}";
                Console.WriteLine($"Now generating {p}");
                if (!File.Exists(path))
                {
                    Console.WriteLine("Failed, file does not exist!");
                    continue;
                }
                var data = JsonConvert.DeserializeObject<ProcessResults>(File.ReadAllText(path));
                File.WriteAllText(outPath, Generator.Generate(data));
            }
            Console.WriteLine("Done generating! Press enter to exit");
            Console.ReadLine();
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