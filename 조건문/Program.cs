namespace 조건문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //날짜, 시간
            Console.Write(DateTime.Now.Year);   //년
            Console.Write(DateTime.Now.Month);  //월
            Console.Write(DateTime.Now.Day);    //일
            Console.Write(DateTime.Now.Hour);   //시
            Console.Write(DateTime.Now.Minute); //분
            Console.Write(DateTime.Now.Second); //초

            //오전, 오후 if, else문
            if (DateTime.Now.Hour < 12)
                Console.WriteLine($"현재 시각은 {DateTime.Now.Hour}시로 오전입니다.");
            else
                Console.WriteLine($"현재 시각은 {DateTime.Now.Hour}시로 오후입니다.");

            //짝수, 홀수 switch문
            Console.Write("정수 입력: ");
            int input = int.Parse(Console.ReadLine());
            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다.");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break;
            }

            //3항 연산자
            Console.WriteLine($"input{input}은 {(input % 2 == 0 ? "짝수이다" : "홀수이다")}");
            Console.WriteLine("input" + input + "은 " + (input % 2 == 0 ? "짝수이다" : "홀수이다"));

            //조건 분할
            Console.Write("입력: ");
            String line = Console.ReadLine();

            if (line.Contains("안녕"))
            {
                Console.WriteLine("나도 안녕");
            }

            //키 입력 받기
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.WriteLine("위쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.WriteLine("아래쪽으로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Console.WriteLine("왼쪽으로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    default:
                        Console.WriteLine("다른 키 입력");
                        break;
                }
            }
        }
    }
}
