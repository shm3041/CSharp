namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chars;
            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            Console.Write("문자열을 입력해주세요: ");
            chars = Console.ReadLine();

            foreach (var item in chars)
            {
                if (item >= '0' && item <= '9')
                    digitCount++;
                else if ((item >= 'A' && item <= 'Z') ||
                         (item >= 'a' && item <= 'z'))
                    alphabetCount++;
                else
                    specialCharCount++;
            }

            Console.WriteLine("분석 결과:");

            Console.WriteLine($"알파벳: {alphabetCount}개");

            Console.WriteLine($"숫자: {digitCount}개");

            Console.WriteLine($"특수문자: {specialCharCount}개");

            Console.WriteLine("\n프로그램을 종료하려면 아무 키나 누르세요...");

            Console.ReadKey();
        }
    }
}
