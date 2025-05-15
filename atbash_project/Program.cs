using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace atbash_project
{
    internal class Program
    {
        static void print_data_of_messege(string messege, int counte)
        {
            string WARNING = "";
            if (counte <= 5)
            {
                WARNING = "WARNING";
            }
            else if (counte > 6 && counte <= 10)
            {
                WARNING = "DANGER!";
            }
            else if(counte > 10)
            {
                WARNING = "ULTRA ALERT!";
            }
            Console.WriteLine($"The message is: {messege} \n The number of suspicious words is: {counte} \n The severity level of the message {WARNING}");

        }



        static void Search_for_suspicious_words(string message, Array bad_words)
        {
            string CleanMessage = Regex.Replace(message, @"[^\w\s]", "");
            String[] new_mesege = CleanMessage.Split(' ');
            int my_counte = 0;
            foreach (string word_suspicious in bad_words)
            {
                foreach (string woed_message in new_mesege)
                {
                    if (woed_message == word_suspicious) my_counte++;
                }
               
            }
            print_data_of_messege(message, my_counte);

        }

        static void Main(string[] args)
        {

            string massage = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\n" +
                "Gsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\n" +
                "Ylnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\n" +
                "Mfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\n" +
                "Gsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\n" +
                "Dv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\n" +
                "Erxglib rh mvzi. Hgzb ivzwb.\r\n";

            string[] bedWords = {"bomb", "nukhba", "fighter", "rocket", "secret"};
            string massageGood = Class1.Encription(massage);
            Search_for_suspicious_words(massageGood, bedWords);

        }
    }
}
