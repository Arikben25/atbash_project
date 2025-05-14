using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace atbash_project
{
    internal class Class1
    {
        public static string Encription(string text)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string newStr = "";
            

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    newStr += abc[(abc.Length - 1) - abc.IndexOf(char.ToLower(c))];
                }
                else
                {
                    newStr += c;
                }

            }
        return newStr ;

        }
    }
}
