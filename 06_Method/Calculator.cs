namespace Method
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            Console.WriteLine("Input : {0}, {1}", a, b);

            int result = a + b;
            return result;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class MainApp
    {
        public static void Main()
        {
            int result = Calculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);
        }
    }
}

