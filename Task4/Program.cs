using System.Dynamic;
using System.Security.Cryptography;

namespace Task4
{
    class GeometryCalculator
    {
        //넓이
        public static int CalculateArea(int r) { return r * r; } //정사각형
        public static int CalculateArea(int r1, int r2) { return r1 * r2; } //직사각형
        public static double CalculateArea(double PI, int r1, int r2) { return PI * r1 * r2; } //원
        public static int CalculateArea(int r1, int r2, char c) { return (r1 * r2) / 2; } //삼각형

        public static int CalculatePerimeter(int r) { return r * 4; } //정사각형
        public static int CalculatePerimeter(int r1, int r2) { return 2 * (r1 + r2); } //직사각형
        public static double CalculatePerimeter(double PI, int r) { return 2 * PI * r; } //원
        public static int CalculatePerimeter(int r1, int r2, int r3) { return r1 + r2 + r3; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            while(true)
            {
                //선택지
                Console.WriteLine("\n도형 계산기");
                Console.WriteLine("1. 정사각형");
                Console.WriteLine("2. 직사각형");
                Console.WriteLine("3. 원");
                Console.WriteLine("4. 삼각형");
                Console.WriteLine("0. 종료");
                Console.Write("선택하세요: ");
                choice = int.Parse(Console.ReadLine());

                int r, r1, r2, r3; //반지름
                int iResult; //int 결과
                double dResult; //double 결과
                switch (choice)
                {
                    case 1:
                        Console.Write("r 입력: ");
                        r = int.Parse(Console.ReadLine());
                        iResult = GeometryCalculator.CalculateArea(r);
                        Console.WriteLine($"정사각형 넓이: {iResult}");

                        Console.Write("r 입력: ");
                        r = int.Parse(Console.ReadLine());
                        iResult = GeometryCalculator.CalculatePerimeter(r);
                        Console.WriteLine($"정사각형 둘레: {iResult}");
                        break;

                    case 2:
                        Console.Write("r1 입력: ");
                        r1 = int.Parse(Console.ReadLine());
                        Console.Write("r2 입력: ");
                        r2 = int.Parse(Console.ReadLine());
                        iResult = GeometryCalculator.CalculateArea(r1, r2);
                        Console.WriteLine($"직사각형 넓이: {iResult}");

                        Console.Write("r1 입력: ");
                        r1 = int.Parse(Console.ReadLine());
                        Console.Write("r2 입력: ");
                        r2 = int.Parse(Console.ReadLine());
                        iResult = GeometryCalculator.CalculatePerimeter(r1, r2);
                        Console.WriteLine($"직사각형 둘레: {iResult}");
                        break;

                    case 3:
                        Console.Write("r1 입력: ");
                        r1 = int.Parse(Console.ReadLine());
                        Console.Write("r2 입력: ");
                        r2 = int.Parse(Console.ReadLine());
                        dResult = GeometryCalculator.CalculateArea(Math.PI, r1, r2);
                        Console.WriteLine($"원 넓이: {dResult}");

                        Console.Write("r 입력: ");
                        r = int.Parse(Console.ReadLine());
                        dResult = GeometryCalculator.CalculatePerimeter(Math.PI, r);
                        Console.WriteLine($"원 둘레: {dResult}");
                        break;

                    case 4:
                        Console.Write("밑변을 입력: ");
                        r1 = int.Parse(Console.ReadLine());
                        Console.Write("높이를 입력: ");
                        r2 = int.Parse(Console.ReadLine());
                        iResult = GeometryCalculator.CalculateArea(r1, r2, 'T');
                        Console.WriteLine($"삼각형 넓이: {iResult}");

                        Console.Write("r1 입력: ");
                        r1 = int.Parse(Console.ReadLine());
                        Console.Write("r2 입력: ");
                        r2 = int.Parse(Console.ReadLine());
                        Console.Write("r3 입력: ");
                        r3 = int.Parse(Console.ReadLine());
                        iResult = GeometryCalculator.CalculatePerimeter(r1, r2, r3);
                        Console.WriteLine($"삼각형 둘레: {iResult}");
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("올바른 숫자를 입력하세요");
                        break;
                }
            }
        }
    }
}