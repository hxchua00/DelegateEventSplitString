using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventSplitString
{
    class StringToSplit
    {
        string message;
        string[] splitStr;
        public StringToSplit(string message)
        {
            this.message = message;
        }

        public void SplitStringCount(string msg)
        {
            splitStr = msg.Split(' ', '.', ',', '?', '!');

            Console.WriteLine("Number of words is " + splitStr.Length);
            Console.WriteLine();

            foreach (var s in splitStr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
    }
}
