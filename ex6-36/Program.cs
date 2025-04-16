namespace ex6_36
{
    class Fibonacci
    {
        //Dictionary 사용 시 재귀함수에서 불필요하게 반복적으로 호출되는 부분을
        //메모를 해둬서 호출수를 줄여준다.
        private static Dictionary<int, long> memo = new Dictionary<int, long>();
        public static long Get(int i)
        {
            if(i <= 0) { return 0; }
            if(i == 1) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(2));
            Console.WriteLine(Fibonacci.Get(3));
            Console.WriteLine(Fibonacci.Get(4));
            Console.WriteLine(Fibonacci.Get(5));
        }
    }
}
