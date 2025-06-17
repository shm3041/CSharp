namespace 상속
{
    class Animal : Object // (모든 클래스는 Object의 자식이다. (상속))  |  Object는 최상위 클래스이다.
    {
        public int Age { get; set; }
        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다"); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }

        //====================================

        public void TestPublic() { }
        protected void TestProtected() { }
        private void TestPriavte() { }

        public void TestA()
        {
            TestPublic();
            TestProtected();
            TestPriavte();
        }
    }

    class Dog : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈 짖습니다."); }

        //========================================

        public void TestB()
        {
            base.TestPublic();
            this.Bark();
            TestPublic();
            TestProtected();
            //TestPriavte();
        }
    }

    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }

    class Tiger : Animal
    {
        public void Sleep() { Console.WriteLine("잡니다."); }
    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            Dog dog2 = new Dog();
            dog2.TestPublic();

            //======================================

            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }

            //=======================================

            List<Animal> Animals = new List<Animal>()
            { new Dog(), new Cat(), new Cat(), new Dog(),
              new Dog(), new Cat(), new Dog(), new Dog()
            };
            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                //무엇이 Dog, Cat인지 모름
                //((Dog)item).Bark();
                //((Cat)item).Meow();

                if (item is Dog) { ((Dog)item).Bark(); } // is 키워드 : ~클래스라면
                if (item is Cat) { ((Cat)item).Meow(); }

                //  is : item이 특정 클래스인가 확인.  |  as : item을 특정 크래스로 형변환 (실패 시 null 반환)
                if (item is Dog) { (item as Dog).Bark(); }
                if (item is Dog) { (item as Cat).Meow(); } // null 반환

                //  as 키워드를 사용하는 일반적인 형태
                var dog = item as Dog;
                if(dog != null ) { dog.Bark(); }

                var cat = item as Cat;
                if(cat != null) { cat.Meow(); }
            }

            //========================================

            Console.WriteLine("\n");

            List<Object> listOfObjectA = new List<Object>();
            listOfObjectA.Add(new Dog());
            listOfObjectA.Add(new Cat());

            foreach (var item in listOfObjectA)
            {
                if (item is Animal) //listOfObjectA에 Dog, Cat만 있어도 Animal의 Eat, Sleep을 사용할 수 있다.
                { 
                    ((Animal)item).Eat();
                    ((Animal)item).Sleep();
                }
                if (item is Dog) { ((Dog)item).Bark(); }
                if (item is Cat) { ((Cat)item).Meow(); }

            }

            List<Object> listOfObjectB = new List<Object>(); //숫자 등도 삽입이 가능하다.
            listOfObjectB.Add(new Dog());
            listOfObjectB.Add(new Cat());
            listOfObjectB.Add(52);
            listOfObjectB.Add(52L);
            listOfObjectB.Add(52.273f);
            listOfObjectB.Add(52.273);

            //========================================





        }
    }
}
