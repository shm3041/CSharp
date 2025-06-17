namespace 쉐도잉_하이딩
{
    internal class Program
    {
        class Parent
        {
            public int variable = 273;

            public virtual void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            //new = 하이딩  :  override, virtual = 쉐도잉
            public new string variable = "shadowing";

            public override void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main(string[] args)
        {
            Child childA = new Child();
            Console.WriteLine(childA.variable); //하이딩
            Console.WriteLine(((Parent)childA).variable); //쉐도잉

            Child childC = new Child();
            childC.Method();
            ((Parent)childC).Method();
        }
    }
}
