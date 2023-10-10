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
            using (StreamReader reader = new StreamReader(filename))
            {

                string content = reader.ReadToEnd();
                char[] characters = content.ToCharArray();

                
                string[] charArray = new string[characters.Length];
                for (int i = 0; i < characters.Length; i++)
                {
                    charArray[i] = characters[i].ToString();
                }

                return charArray;

               
            }
        }
    }
}
