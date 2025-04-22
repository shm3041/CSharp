namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.Write("1-100의 정수를 입력: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine($"intput: {input}");

            for(int i = 0; i <= input; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
