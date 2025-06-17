namespace 제네릭
{
    internal class Program
    {
        class Wanted<T>
        {
            public T value; // 변수
            public Wanted(T value) // 함수
            {
                this.value = value;
            }
        }

        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("String");
            Console.WriteLine($"wantedString의 값: {wantedString.value}");
        }
    }
}
