namespace 클래스
{
    class Car
    {
        public Car()
        {
            Console.WriteLine("기본 생성자");
        }
        public Car(string st) { Console.WriteLine($"{st} 있는 생성자"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //인스턴스 생성
            Car car1 = new Car();
            //매개변수 있는 인스턴스 생성
            Car car2 = new Car("매개변수");

            //랜덤 인스턴스 생성
            Random random = new Random();
            Console.WriteLine(random.Next(10, 101)); //10이상 101 미만의 랜덤 숫자 생성 (이상, 미만)
            Console.WriteLine(random.NextDouble()); //0이상 1.0 미만의 랜덤 숫자 생성 (이상, 미만)
            Console.WriteLine(random.NextDouble() * 10); //0이상 10.0미만
            Console.WriteLine(10.0 + random.NextDouble() * 90); //10.0이상 100.0미만
        }
    }
}
