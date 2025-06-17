namespace TryParse__out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            // int.TryParse(a, out b) :: A의 값이 int라면 B에 삽입
            // 범위: 2^31
            bool result = int.TryParse(Console.ReadLine(), out a);
            if(result)
            {
                Console.WriteLine($"입력한 숫자: {a}");
            }
            else
            {
                Console.WriteLine("숫자를 입력할것");
            }
        }
    }
}
