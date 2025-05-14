using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atbash_project
{
    internal class Class2
    {
        public static print_data_of_messege(string messege, int counte)
        {   string WARNING = ""
            if (counte <= 5)
            {
                WARNING = "WARNING"
            }
            else if (counte > 6 && counte <= 10)
            {
                WARNING = "DANGER!"
            }
            else (WARNING > 10){
                WARNING = "ULTRA ALERT!"
            }
            Console.WriteLine($"The message is: {messege} \n The number of suspicious words is: {counte} \n The severity level of the message {WARNING}");   

        }
    }
}
