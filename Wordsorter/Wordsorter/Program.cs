using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Wordsorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] words;
            if(File.Exists("wordlist 1.txt"))
            {
                words = File.ReadAllLines("wordlist 1.txt");
                Console.WriteLine(words[20]);
            }

        }
    }
}
