namespace Ex1_DigitSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("정수를 입력하세요: ");
            input = Console.ReadLine();

            if (int.Parse(input) < 0)
            {
                Console.WriteLine("양의 정수를 입력해주세요.");
            }

            int print, result = 0;
            Console.Write("각 자리수의 합: ");
            for (int i = 0; i < input.Length; i++)
            {
                print = input[i];
                Console.Write($"{print - 48} + ");
                result += print - 48;
            }
            Console.Write("\b\b");
            Console.WriteLine($"= {result}");
        }
    }
}
