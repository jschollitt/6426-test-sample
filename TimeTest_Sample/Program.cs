using System;

namespace TimeTest_Sample
{
    class Program
    {
        /// <summary>
        /// Program main. This is where the application begins.
        /// </summary>
        static void Main()
        {
            Test.RunTest(Fibonacci);
        }

        /// <summary>
        /// Sample method for test demonstration.
        /// This method will print  'n' fibonacci sequence numbers
        /// </summary>
        /// <param name="n"></param>
        static void Fibonacci(int n)
        {
            UInt64 a = 0;
            UInt64 b = 1;
            UInt64 c;

            for (var i = 2; i < n; i++)
            {
                c = a + b;
                /// Uncomment the line below to see the fibonacci output
                /// note: This will significantly slow down execution
                // Console.Write(c);
                a = b;
                b = c;
            }
        }
    }
}
