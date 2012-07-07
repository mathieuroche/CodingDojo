using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// Fibo réalisé via TDD cf. http://www.scribd.com/doc/95256245/38/CHAPTER-38-Fibonacci
namespace Fibo
{
    public class Fibo1
    {
        public static int Go(int n)
        {
            return 0;
        }
    }

    public class Fibo2
    {
        public static int Go(int n)
        {
            return n;
        }
    }

    public class Fibo3
    {
        public static int Go(int n)
        {
            if (n == 0)
                return 0;
            else
                return 1;
        }
    }

    public class Fibo4
    {
        public static int Go(int n)
        {
            if (n == 0)
                return 0;
            else if (n <= 2)
                return 1;
            else
                return Go(n-1) + Go(n-2); // 2 => 1 + 1 => fib(n-1) + 1 => fib(n-1) + fib(n-2)
        }
    }
}
