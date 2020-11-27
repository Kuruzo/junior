using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirstGame
{
    class FileReader
    {
        public List<string> LoadFromFile(string fileName)
        {
            List<string> fileInput = ReadMapInputFromFile(fileName);
            foreach (string line in fileInput)
            {
                Console.WriteLine(line);
            }

            return fileInput;
        }

        private List<string> ReadMapInputFromFile(string fileName)
        {
            List<string> input = new List<string>();

            using (StreamReader sReader = File.OpenText(fileName))
            {
                string line;
                while (!sReader.EndOfStream)
                {
                    line = sReader.ReadLine();
                    input.Add(line);
                }
            }

            return input;
        }
    }
}
