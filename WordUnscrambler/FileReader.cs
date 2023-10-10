using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string content = "";

            while (!reader.EndOfStream)
            {
                content += reader.ReadLine() + ",";
            }

            string[] stringArray = content.Split(',');

            return stringArray;
        }
    }
}
