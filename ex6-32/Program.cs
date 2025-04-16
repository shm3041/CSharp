namespace ex6_32
{
    internal class Program
    {
        class Test
        {
            public int value = 10;
        }

        static void Change(Test input)
        {
            input.value = 20;
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            Change(test);

            Console.WriteLine(test.value);

            Test testA = new Test();
            Test testB = testA;
            testA.value = 10;
            testB.value = 20;
            Console.WriteLine(testA.value);
        }
    }
}
