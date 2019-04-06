using System;
namespace Test
{
    public class BinaryGap
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(2147483647));
            Console.WriteLine(Solution(529));
            Console.WriteLine(Solution(1041));
            Console.WriteLine(Solution(1));
            Console.WriteLine(Solution(3));
            Console.WriteLine(Solution(5));
            Console.WriteLine(Solution(32));
        }

        static int Solution(int N)
        {
            int Longest = 0, ZeroCtr = 0;

            foreach (char c in Convert.ToString(N, 2))
            {
                if (c == '0')
                    ZeroCtr++;
                else
                {
                    if (ZeroCtr > Longest)
                        Longest = ZeroCtr;
                    ZeroCtr = 0;
                }
            }

            return Longest;
        }

    }
}
