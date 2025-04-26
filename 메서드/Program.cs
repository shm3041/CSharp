using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace 메서드
{
    class Box
    {
        private int width;
        private int height;

        public Box(int width = 1, int height = 1)
        {
            if(width > 0 || height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else { Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!"); }
        }

        public int Area() { return this.width * this.height; }

        //게터
        public int GetWidth() { return width; }
        public int GetHeight() { return height; }

        //세터
        public void SetWidth(int width)
        {
            if (width > 0) { this.width = width;}
            else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
        }

        public void SetHeight(int height)
        {
            if (height > 0) { this.height = height; }
            else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
        }

        //위와 같은 게터와 세터 형식을 일반적으로 아래와 같이 사용함
        //propfull
        private int test;
        public int Test
        {
            get { return test; }
            set { test = value; }
        }
    }


    class Fibonacci
    {
        //Dictionary 사용 시 재귀함수에서 불필요하게 반복적으로 호출되는 부분을
        //메모를 해둬서 호출수를 줄여준다.
        private static Dictionary<int, long> memo = new Dictionary<int, long>();
        public static long Get(int i)
        {
            if (i <= 0) { return 0; }
            if (i == 1) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }
    }

    //참조복사
    class Copy
    {
        public int value = 10;
    }

    internal class Program
    {
        //참조복사
        static void Change(Copy input)
        {
            input.value = 20;
        }

        static void Main(string[] args)
        {
            Box box = new Box();
            box.Test = 10; //세터
            Console.WriteLine($"게터: {box.Test}");

            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(2));
            Console.WriteLine(Fibonacci.Get(3));
            Console.WriteLine(Fibonacci.Get(4));
            Console.WriteLine(Fibonacci.Get(5));

            //참조 복사
            Copy copy = new Copy();
            Change(copy);
            Console.WriteLine(copy.value);

            Copy copyA = new Copy();
            Copy copyB = copyA;
            copyA.value = 10;
            copyB.value = 20;
            Console.WriteLine(copyA.value);
        }
    }
}
