using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atbash_project
{
    internal class Class3
    {
        public static void menager(string text, string[] dangerous_words)
        {
            string text_encr = Class1.Encription(text);
            Program.ReferenceEquals(text_encr, dangerous_words);




        } 
    }
}
