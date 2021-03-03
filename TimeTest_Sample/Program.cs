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
            //Test.RunTest(NestedLoops);
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

        static void NestedLoops(int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                        count++;
                }
            }
            Console.WriteLine("Count: {0}", count);
        }
    }
}
