namespace CS0314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수 선언
            string name, student_num;
            int math, english, sum;
            double avg;

            //값 입력
            Console.Write("학생 이름을 입력하세요: ");
            name = Console.ReadLine();

            Console.Write("학번을 입력하세요: ");
            student_num = Console.ReadLine();

            Console.Write("수학 점수를 입력하세요: ");
            math = int.Parse(Console.ReadLine());

            Console.Write("영어 점수를 입력하세요: ");
            english = int.Parse(Console.ReadLine());


            //값 출력
            Console.WriteLine("\n");
            Console.WriteLine("=== 학생 정보 ===");
            Console.WriteLine("이름: " + name + " (자료형: " + name.GetType() + ")");
            Console.WriteLine("학번: " + student_num + " (자료형: " + student_num.GetType() + ")\n");

            Console.WriteLine("=== 성적 정보 ===");
            Console.WriteLine("수학: " + math + "점 (자료형: " + math.GetType() + ")");
            Console.WriteLine("영어: " + english + "점 (자료형: " + english.GetType() + ")\n");

            sum = math + english;
            avg = (double)(math + english) / 2;
            Console.WriteLine("=== 계산 결과 ===");
            Console.WriteLine("총점: " + sum + "점 (자료형: " + sum.GetType() + ")");
            Console.WriteLine("평균: " + avg + "점 (자료형: " + avg.GetType() + ")\n");
        }
    }
}