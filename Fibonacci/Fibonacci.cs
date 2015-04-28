using System;
using System.IO;

namespace Fibonacci
{
    class Fibonacci
    {
        static int Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (null == line) continue;

                    if ("" == line) continue;

                    long n = long.Parse(line);

                    Console.WriteLine(SolveFibonacci(n));
                }
            }

            return 0;
        }

        /// <summary>
        /// Solve for f(n), the Fibonacci sequence, non recursively
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long SolveFibonacci(long n)
        {
            if (n == 0L)
            {
                return 0L;
            }

            if (n == 1L)
            {
                return 1L;
            }

            long minus1 = 0;
            long minus2 = 1;
            long sum = 0;

            for (long count = 1; count <= n; ++count)
            {
                sum = minus1 + minus2;

                minus2 = minus1;
                minus1 = sum;
            }

            return sum;
        }

        /// <summary>
        /// Solve for f(n), Fibonacci recursively.
        /// Note to self: This gets hella slow when n = 30-40+
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long RecursiveSolveFibonacci(long n)
        {
            if (n == 0L)
            {
                return 0L;
            }
            else if (n == 1L)
            {
                return 1L;
            }
            else
            {
                return RecursiveSolveFibonacci(n - 1L) + RecursiveSolveFibonacci(n - 2L);
            }
        }
    }
}
