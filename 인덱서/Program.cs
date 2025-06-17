namespace 인덱서
{
    internal class Program
    {
        class SquareCalculator
        {
            public int this[int i]
            {
                get
                {
                    return i * i;
                }
            }
        }

        static void Main(string[] args)
        {
            SquareCalculator square = new SquareCalculator();
            Console.WriteLine(square[10]);
            Console.WriteLine(square[20]);
            Console.WriteLine(square[30]);
        }
    }
}
