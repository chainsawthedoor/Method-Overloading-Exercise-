namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool isCurrency)
        {
            var sum = numOne + numTwo;
            if (isCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }

        public static double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 2));
            Console.WriteLine(Add(2, 2.5m));
            Console.WriteLine(Add(1, 1, true));
        }
    }
}
