using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventSplitString
{
    public delegate void SplitStringEventHandler(string msg);
    class Program
    {
        public static event SplitStringEventHandler NewSplit;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string here: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            StringToSplit split = new StringToSplit(input);

            NewSplit += split.SplitStringCount;
            NewSplit.Invoke(input);

            Console.ReadLine();
        }
    }
}
