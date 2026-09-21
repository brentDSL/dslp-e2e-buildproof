// The customer-journey proof for an Any CPU C# solution (J25).
//
// It says what it is on stdout and writes the same words to a file in its
// WORKING DIRECTORY, so the journey can assert on both: an empty file with the
// right name satisfies neither.
using System;
using System.IO;

namespace AnyCpuApp
{
    public static class Program
    {
        public const string Marker = "dslp msbuildproof csharp ok";

        public static int Main(string[] args)
        {
            Console.WriteLine(Marker);
            File.WriteAllText("dslp_msbuildproof_csharp.txt", Marker + Environment.NewLine);
            return 0;
        }
    }
}
// webhook-build push ea28bbb8436e33ba
