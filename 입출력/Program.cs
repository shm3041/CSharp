namespace 입출력
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //출력 함수
            Console.Write("");
            Console.WriteLine("");

            //입력 함수
            Console.ReadLine();

            //정수, 실수 변환 함수
            int a = int.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            //변수 + 문자열 출력
            Console.WriteLine($"정수 a는 {a}입니다.\n실수 b는 {b}입니다.");
            Console.WriteLine($"string자료형의 크기: {"안녕".GetType()}");

            //정수, 실수, 문자, 문자(문자선택) 출력
            Console.WriteLine(0);
            Console.WriteLine(0.0);
            Console.WriteLine('가');
            Console.WriteLine("안녕하세요"[0]);

            // TAB: \t      역슬래시: \\      행바꿈: \n    큰따옴표
            // 자료형.MaxValue    자료형.MinValue
            // 문자열변환: (변수 or 상수).ToString();      소수점: 변수.ToString("0.00");


        }
    }
}