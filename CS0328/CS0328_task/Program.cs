namespace CS0328_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int select;
            
            //숫자 맞추기 게임 변수
            int input_num;
            int rnd_num;
            int flags_num = 0;

            //구구단 연습 게임 변수
            int mul_goo;

            //Program Main
            Console.WriteLine("=== 숫자 게임 프로젝트 ===");
            while (true)
            {
                //메뉴 출력
                Console.WriteLine();
                Console.WriteLine("==== 메뉴 ====");
                Console.WriteLine("1. 숫자 맞추기");
                Console.WriteLine("2. 구구단 연습");
                Console.WriteLine("0. 종료");
                Console.Write("메뉴를 선택하세요: ");

                //선택지 입력
                select = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //숫자 맞추기 (선택지 1)
                if (select == 1)
                {
                    Console.WriteLine("=== 숫자 맞추기 게임 ===");
                    Console.WriteLine("1부터 50 사이의 숫자를 맞춰보세요!");
                    rnd_num = random.Next(1, 51);

                    do
                    {
                        Console.Write("숫자를 입력하세요 (1-50, 0 입력시 포기): ");
                        input_num = int.Parse(Console.ReadLine());

                        if (1 <= input_num && input_num <= 50)
                        {
                            flags_num++;

                            if (input_num < rnd_num) Console.WriteLine("더 큰 숫자입니다!"); 
                            else if (rnd_num < input_num) Console.WriteLine("더 작은 숫자입니다!"); 
                            else Console.WriteLine("정답입니다! " + flags_num + "번 만에 맞추셨습니다.\n"); 
                        }
                        else if (input_num == 0)
                        {
                            Console.WriteLine("정답은 " + rnd_num + "였습니다!");
                            break;
                        }
                        else Console.WriteLine("1부터 50 사이의 숫자를 입력하세요.");

                    } while (input_num != rnd_num);
                }

                //구구단 연습 (선택지 2)
                else if (select == 2)
                {
                    Console.WriteLine("=== 구구단 연습 ===");
                    Console.Write("몇 단을 연습하시겠습니까? (1-9): ");
                    mul_goo = int.Parse(Console.ReadLine());

                    if (0 < mul_goo && mul_goo < 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("[" + mul_goo + "단]");

                        for (int i = 1; i <= 9; i++)
                            Console.WriteLine(mul_goo + " x " + i + " = " + mul_goo * i);
                        Console.WriteLine();

                        Console.WriteLine("[역순 구구단]");
                        for (int i = 9; i >= 1; i--)
                            Console.WriteLine(mul_goo + " x " + i + " = " + mul_goo * i);
                    }
                    else Console.WriteLine("1-9 사이의 숫자를 입력하세요.");
                }

                //잘못된 입력 시 or 0 입력 시 실행
                else if (select == 0) break;
                else Console.WriteLine("0-2 사이의 메뉴를 선택하세요.");
            }
        }
    }
}
