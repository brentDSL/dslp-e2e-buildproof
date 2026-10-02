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
// webhook-build push 10d7921d6cbf4234
// webhook-build push f9ee38da064d4d71
// webhook-build push 7d8d3b1be3c8a577
// webhook-build push 4cc86aa2d1fbd1c1
// webhook-build push 394da75c9687eec5
// webhook-build push bf4668cc6324a79b
