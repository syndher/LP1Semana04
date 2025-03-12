using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace BetterDecor
{
    /// <summary>
    /// Writes a sentence with characters by it's side separated by a space,
    /// the character and the amount of characters can be manually chosen by the user
    /// </summary>
    class Program
    {
        /// <summary>
        /// Converts the input given into different variables and writes the sentence on the console
        /// </summary>
        /// <param name=args>String, Character and Integer given in the console</param>
        private static void Main(string[] args)
        {   
            int x = 0;

            foreach (string arg in args)
            {
                x += x;
                return;
            }
            if (x == 3)
            {
                ///Converts each input into the correct format (String, Character, Integer)
                string s = args[0];
                char dec = char.Parse(args[1]);
                int n = int.Parse(args[2]);

                Console.WriteLine(Decor(s, dec, n)); /// Writes the sentence with the character by it's side
            }
            else if (x == 0)
            {
                Console.WriteLine(Decor("User did not specify args!", '=', 3));
            }   
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">String given by the user</param>
        /// <param name="dec">Character given by the user</param>
        /// <param name="n">Integer given by the user</param>
        /// <returns>The sentence with "n" amount of characters</returns>
        private static string Decor(string s, char dec, int n)
            {
                string decs = "";
                int i;

                for (i = 0; i < n; i++) ///Creates a new string with "n" characters by it's side
                    {
                        decs += dec;
                    }
                return $"{decs} {s} {decs}"; 
            }
    }
}
