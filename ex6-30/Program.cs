namespace ex6_30
{
    internal class Program
    {
        static void Change(int input)
        {
            input = 20;
        }

        static void Main(string[] args)
        {
            int a = 10;
            Change(a);
            Console.WriteLine(a);
        }
    }
}
