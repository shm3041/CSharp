namespace sealed_키워드
{
    internal class Program
    {
        // 1. sealed 예제
        //sealed class Parent
        //{
        //    public void Test() { }
        //}

        //class Child // : Parent를 하여도 sealed 키워드 때문에 상속이 불가능하다.
        //{
        //    public void Test() { }
        //}

        //================================

        // 2. sealed method 예제
        //class Parent
        //{
        //    public virtual void Test() { }
        //}

        //class Child : Parent
        //{
        //    sealed public override void Test() { } //sealed 키워드로 상속 불가를 명시해줌
        //}

        //class GrandChild : Child
        //{
        //    //public override void Test() { } // sealed 키워드 때문에 상속 불가
        //}

        //================================

        //3. abstract class 예제
        //abstract class Parent
        //{
        //    public void Test() { }
        //}

        //class Child : Parent
        //{
        //    public void Test() { }
        //}

        //================================

        //4. abstract method 예제
        abstract class Parent
        {
            public abstract void Test(); // {} 없이 세미콜론으로 바로 끝난다.
        }

        class Child : Parent
        {
            //abstract 메서드와 관련된 오류 해결
            //Parent에서 추상적으로 선언해준 함수를 구체화 하였음. 따라서 Test()가 사용이 가능하다.
            public override void Test() { }
        }

        static void Main(string[] args)
        {
            //3. abstract 예제에서는 사용이 불가능하다. (추상이기 때문에 사용불가)
            //Parent parent = new Parent();
            Child child = new Child();

            //3. abstract 예제에서는 사용이 불가능하다. (추상이기 때문에 사용불가)
            //parent.Test();
            child.Test();
        }


    }
}
