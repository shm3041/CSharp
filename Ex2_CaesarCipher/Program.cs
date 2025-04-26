namespace Ex2_CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            Console.Write("암호화할 문자열을 입력하세요: ");
            str = Console.ReadLine();

            int shift = 0;
            Console.Write("시프트 값을 입력하세요(1-25): ");
            shift = int.Parse(Console.ReadLine());

            Console.Write("암호화된 문자열: ");
            char print = ' ';
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'w') || (str[i] >= 'A' && str[i] <= 'W'))
                {
                    print = str[i];
                    print = (char)(print + shift);
                    Console.Write(print);
                }
                else if ((str[i] >= 'x' && str[i] <= 'z') || (str[i] >= 'X' && str[i] <= 'Z'))
                {
                    print = (char)(str[i] - 26);
                    print = (char)(print + shift);
                    Console.Write(print);
                }
                else
                {
                    Console.Write(str[i]);
                }
            }
        }
    }
}
