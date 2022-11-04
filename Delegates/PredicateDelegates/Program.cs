using System;

namespace PredicateDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> predicateDelegate = IsEven;

            Console.WriteLine(predicateDelegate(4));
            Console.WriteLine(predicateDelegate(7));
            Console.WriteLine(predicateDelegate(2));
        }
        
        static bool IsEven(int inputNum)
        {
            if ((inputNum % 2) == 0)
                return true;
            else
                return false;
        }
    }
}