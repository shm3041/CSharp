namespace 생성자
{
    internal class Program
    {
        class Parent
        {
            public static int counter = 0;

            public Parent() { Console.WriteLine("부모 생성자"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(string param) { Console.WriteLine("Parent(string param)"); }

            public void CountParent()
            {
                Parent.counter++;
            }
        }

        class Child : Parent
        {
            //함수명과 매개변수가 Child() : base(10)과 동일하므로 중복됨. 따라서 주석처리 해주었음.
            //public Child() : base() //기본적으로 base()가 생략된 형태이다. (부모 생성자를 호출)
            //{
            //    Console.WriteLine("자식 생성자"); 
            //}
            public Child() : base(10)
            {
                Console.WriteLine("Child() : base(10)");
            }
            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input) : base(input)");
            }

            public void CountChild()
            {
                Child.counter++; //상속받았지만 여전히 Parent의 counter 변수를 사용한다. 따라서 Parent에 선언되어 있는 counter 변수가 증가한다.
            }
        }

        static void Main(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child("string");

            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
        }
    }
}
