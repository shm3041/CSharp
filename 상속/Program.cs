using System.Data;

namespace 상속
{
    class Animal
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


    internal class Program
    { 
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.TestPublic();

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

                if (item is Dog) { ((Dog)item).Bark(); }
                if (item is Cat) { ((Cat)item).Meow(); }
            }




        }
    }
}
