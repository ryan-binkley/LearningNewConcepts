using System;

namespace CustomDelegates
{
    class Program
    {
        public delegate int ReturnResult(int x, int y, int z);
        
        static void Main(string[] args)
        {
            ReturnResult calculator = new ReturnResult(Add);
            calculator += Multiply;

            calculator.Invoke(17, 4, 20);
        }

        public static int Add(int num1, int num2, int num3)
        {
            Console.WriteLine("The numbers " + num1 + ", " + num2 + ", and " + num3 + " added equals: " + (num1 + num2 + num3));
            return num1 + num2 + num3;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            Console.WriteLine("The numbers " + num1 + ", " + num2 + ", and " + num3 + " multiplied equals: " + (num1 * num2 * num3));
            return num1 * num2 * num3;
        }
    }
}
