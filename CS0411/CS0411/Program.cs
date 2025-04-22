namespace CS0411
{
    internal class Program
    {
        class Student
        {
            string name;
            int age;
            int mathScore, koreanScore;
            static int totalStudents;

            public Student(string name, int age)
            {
                this.name = name;
                this.age = age;
                this.mathScore = 0;
                this.koreanScore = 0;
                totalStudents++;
            }

            public void SetScores(int mathScore, int koreanScore)
            {
                this.mathScore = mathScore;
                this.koreanScore = koreanScore;
            }
            public float CalculateAverage() { return (mathScore + koreanScore) / 2; }
            public void DisplayInfo()
            {
                float avg = (float)(mathScore + koreanScore) / 2;
                Console.WriteLine("=== 학생 정보 ===");
                Console.WriteLine($"이름: {name}\n나이: {age}\n수학: {mathScore}점\n국어: {koreanScore}점");
                Console.WriteLine($"평균: {avg}점\n결과: {(avg >= 60 ? ("합격") : ("불합격"))}");
                //Console.WriteLine("평균: " + avg + "점\n결과: " + (avg >= 60 ? "합격" : "불합격"));
            }
            static public int GetTotalStudents() { return totalStudents; }
        }

        static void Main(string[] args)
        {
            //또한 주석처리 된 빈 코드구간을 채워넣으세요.  
            Console.WriteLine("=== 학생 성적 관리 프로그램 ===");

            // 학생 객체 생성
            Student student1 = new Student("홍길동", 15);
            student1.SetScores(80, 90);

            Student student2 = new Student("김철수", 16);
            student2.SetScores(70, 65);

            // 학생 정보 출력
            student1.DisplayInfo();
            Console.WriteLine();
            student2.DisplayInfo();

            // 클래스 변수와 클래스 메서드 사용 예시
            //이 줄에서 총 학생수를 => 총 학생 수 : 2 명 <= 이렇게 출력하세요. 
            Console.WriteLine($"총 학생 수 : {Student.GetTotalStudents()}명");

            // 사용자로부터 새 학생 정보 입력받기
            Console.WriteLine("\n새 학생 정보를 입력하세요:");

            Console.Write("이름: ");
            string name = Console.ReadLine();

            Console.Write("나이: ");
            int age = int.Parse(Console.ReadLine());     
            
            Console.Write("수학 점수: ");
            int mathScore = int.Parse(Console.ReadLine());

            Console.Write("국어 점수: ");
            int koreanScore = int.Parse(Console.ReadLine());

            // 새 학생 객체 생성 및 점수 설정
            //이 줄에서 새 학생 객체인 newStudent 객체를 만드세요
            Student newStudent = new Student(name, age);

            //이 줄에서 새 학생 객체인 newStudent에 수학과, 국어 점수를 넣으세요
            newStudent.SetScores(mathScore, koreanScore);

            // 새 학생 정보 출력
            Console.WriteLine();
            newStudent.DisplayInfo();

            // 갱신된 총 학생 수 출력
            //이 줄에서 총 학생수를 => 총 학생 수 : 2 명 <= 이렇게 출력하세요. 
            Console.WriteLine($"\n총 학생 수 : {Student.GetTotalStudents()}명");
        }
    }
}
