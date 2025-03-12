using System;
using System.Net;
using System.Runtime.CompilerServices;


namespace BetterDecor
{
    class Program
    {
        private static void Main(string[] args)
        {
            string s = args[0];
            char dec = char.Parse(args[1]);
            int n = int.Parse(args[2]);
            
                

         Console.WriteLine(Decor(args[0], dec, n));
        }
        private static string Decor(string s, char dec, int n)
            {
                string decs = "";
                int i;
                for (i = 0; i < n; i++)
                    {
                        decs += dec;
                    }
                return $"{decs} {s} {decs}"; 
            }
    }
}
