using System;
using System.IO;

namespace Pic2Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArgs = args.Length;
            if (numArgs != 1)
            {
                Console.WriteLine("Invalid arguments");
                return;
            }
            var fileName = args[0];
            Processing.Process(fileName);

        }
    }
}
