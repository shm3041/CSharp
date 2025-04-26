namespace 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열 선언
            int[] intArray = { 1, 2, 3, 4, 5 };
            int[] intArray2 = new int[10]; //공간 10
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
            string[] stringArray = { "홍길동", "신한목", "김민수" };
            string[] array = new string[100]; //size 100
            List<int> list = new List<int>() { 100, 200 }; // 크기가 가변적인 int형 리스트(하단에 사용법 기재(ch05))

            //배열 길이 출력
            Console.WriteLine($"intArray의 크기: {intArray.Length}");

            //for문
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            //foreach문
            foreach (var i in stringArray)
            {
                Console.WriteLine(i);
            }

            //문자 대문자, 소문자 변경
            array[0] = "Potato Tomato";
            Console.WriteLine(array[0].ToUpper());
            Console.WriteLine(array[0].ToLower());

            //문자열 자르기
            string stringVar = "Hello World";
            string[] stringArrays = stringVar.Split(new char[] { ' ' });
            foreach (var i in stringArrays)
            {
                Console.WriteLine(i);
            }

            //리스트 사용법
            list.Add(300);
            list.Add(400);
            list.Remove(100);
            list.Remove(200);

            //문자열 양옆의 공백을 제거: Trim()                   ch04 51P
            //배열을 문자열로 변환: string.Join(",", array);      ch04 53P
            //이동하는 달팽이                                     ch04 54P
        }
    }
}
