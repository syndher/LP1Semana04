using System;
using System.Net;
using System.Runtime.CompilerServices;


namespace BetterDecor
{
    class Program
    {
        /// <summary>
        /// Writes a sentence with characters by it's side, the number of charaters
        /// depends on the value of the integer given
        /// </summary>
        /// <param name=s>String given by the user</param>
        /// <param name=dec>Character given by the user</param>
        /// <param name=n>Integer given by the user</param>
        private static void Main(string[] args)
        {
            ///Converts each input into the correct format (String, Character, Integer)
            string s = args[0];
            char dec = char.Parse(args[1]);
            int n = int.Parse(args[2]);
            
                

         Console.WriteLine(Decor(s, dec, n));   /// Writes the sentence with the character by it's side
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">String given by the user</param>
        /// <param name="dec">Character given by the user</param>
        /// <param name="n">Integer given by the user</param>
        /// <returns>The sentence with the right amount of characters</returns>
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
