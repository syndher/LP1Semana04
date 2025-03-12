using System;


namespace BetterDecor
{

    class Program
    {
        private static void Main(string[] args)
        {   
            int spec = int.Parse(args[0]);
            Console.WriteLine(GetSpecial(spec));
        }
    
        private static int GetSpecial(int n)
        {
            int spe;
            if (n == 0)
                spe = 0;
            else if (n == 1)
                spe = 1;
            else
                spe = GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
            return spe;

        }
    }
}
