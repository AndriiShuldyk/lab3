using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace persheZavd
{
    class Input
    {
        public static string a { set; get; }
        public static string b { set; get; }
        public Input(string a)
        {
            a = Console.ReadLine();
            b = Console.ReadLine();
        }  
    }

    class inputBlue : Input
    {
        public inputBlue() : base(a)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            
        }
    }

    class inputRed : Input
    {
        public inputRed() : base(b)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            
        }
    }

    class firstTask
    {
        static void Main(string[] args)
        {
            inputBlue blueInput = new inputBlue();
            Debug.WriteLine(inputBlue.a);
            Console.WriteLine(inputBlue.a);

            inputRed redInput = new inputRed();
            Debug.WriteLine(inputRed.b);
            Console.WriteLine(inputRed.b);
        }
    }
}
