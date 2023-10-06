using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            char[] array = new char[char.MaxValue];
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                char c = (char)reader.Read();
                array.add(c);
            }
        }
    }
}
