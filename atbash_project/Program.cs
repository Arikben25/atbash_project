using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace atbash_project
{
    internal class Program
    {
        static void Search_for_suspicious_words(string mesege, Array arr)
        {
            String[] new_mesege = mesege.Split(' ');
            List<string> wors_s_is_in = new List<string>();
            bool t_o_f = false;
            int my_counte = 0;
            foreach (string word_s in arr)
            {
                foreach (string woed_m in new_mesege)
                {
                    if (woed_m == word_s) my_counte++;
                }
                if (t_o_f)
                {
                    wors_s_is_in.Add(word_s);
                }
            }
        }
      
        static void Main(string[] args)
        {


        }
    }
}
