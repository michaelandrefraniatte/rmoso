using System;
using System.IO;

namespace rmoso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tEnter a word to search in files");
            string searched = Console.ReadLine();
            string rootPath = System.Windows.Forms.Application.StartupPath;
            string[] fileNames = Directory.GetFiles(rootPath);
            foreach (string fileName in fileNames)
            {
                string txt = File.ReadAllText(fileName);
                if (txt.Contains(searched))
                {
                    Console.WriteLine(fileName);
                }
            }
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            foreach (string dir in dirs)
            {
                string[] files = Directory.GetFiles(dir);
                foreach (string file in files)
                {
                    string txt = File.ReadAllText(file);
                    if (txt.Contains(searched))
                    {
                        Console.WriteLine(file);
                    }
                }
            }
            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}