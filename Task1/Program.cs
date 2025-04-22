using Microsoft.Win32.SafeHandles;

namespace Task1
{
    internal class Program
    {
        //배열의 크기
        const int SIZE = 10;

        //더하기
        public static int CalculateSum(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }

            return sum;
        }

        //평균
        public static double CalculateAverage(int[] array)
        {
            double avg = 0;
            foreach (var item in array)
            {
                avg += item;
            }

            return (avg / SIZE);
        }

        //가장 큰 수
        public static int FindMaximum(int[] array)
        {
            int max = 0;

            foreach (var item in array)
            {
                if (max < item) max = item;
            }

            return max;
        }
        
        //최솟값
        public static int FindMinimum(int[] array)
        {
            int min = (int)2e9;

            foreach (var item in array)
            {
                if (min > item) min = item;
            }

            return min;
        }

        static void Main(string[] args)
        {
            // 테스트를 위한 배열 생성 (크기: 10)
            int[] numbers = { 10, 5, 23, 17, 8, 4, 42, 15, 6, 11 };


            // 각 메서드 호출하여 결과 출력
            Console.WriteLine("배열: [" + string.Join(", ", numbers) + "]");

            Console.WriteLine("합계: " + CalculateSum(numbers));

            Console.WriteLine("평균: " + CalculateAverage(numbers));

            Console.WriteLine("최댓값: " + FindMaximum(numbers));

            Console.WriteLine("최솟값: " + FindMinimum(numbers));

            Console.ReadKey(); // 콘솔 창이 바로 닫히지 않도록
        }
    }
}
