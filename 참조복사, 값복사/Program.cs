namespace 참조복사__값복사
{
    internal class Program
    {
        class PointClass
        {
            public int x;
            public int y;

            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct PointStruct
        {
            public int x;
            public int y;

            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        //얕은 복사, 깊은 복사
        static void Main(string[] args)
        {
            //Class (참조 복사)
            PointClass pointClassA = new PointClass(10, 20);
            PointClass pointClassB = pointClassA;

            pointClassB.x = 100;
            pointClassB.y = 200;

            Console.WriteLine("pointClassA: " + pointClassA.x + "," + pointClassA.y);
            Console.WriteLine("pointClassB: " + pointClassB.x + "," + pointClassB.y);
            Console.WriteLine();

            //Struct (값 복사)
            PointStruct pointStructA = new PointStruct(10, 20);
            PointStruct pointStructB = pointStructA;

            pointStructB.x = 100;
            pointStructB.y = 200;

            Console.WriteLine("pointStrcutA: " + pointStructA.x + "," + pointStructA.y);
            Console.WriteLine("pointStructB: " + pointStructB.x + "," + pointStructB.y);

            //Class에서만 참조 복사가 일어난다.

            //==============================================================================

        }
    }
}
