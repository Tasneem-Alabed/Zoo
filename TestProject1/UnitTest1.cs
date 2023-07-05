using Zoo;




namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Mammals cat = new Cat();
            cat.Name = "kity";
            Assert.Equal("kity", cat.Name);
        }
        [Fact]
        public void Test2()
        {
            Mammals dog = new Dog();
            dog.Name = "josh";
            Assert.Equal("josh", dog.Name);
        }
        [Fact]
        public void Test3()
        {
            Mammals rabbit = new Rabbit();
            rabbit.Name = "roze";
            Assert.Equal("roze", rabbit.Name);
        }

        [Fact]
        public void Test4()
        {
            Reproduces_with_eggs fish = new Fish();
            fish.Name = "roze";
            Assert.Equal("roze", fish.Name);
        }
        [Fact]
        public void Test5()
        {
            Reproduces_with_eggs pin = new Pinguin();
            pin.Name = "pin";
            Assert.Equal("pin", pin.Name);
        }
        [Fact]
        public void Test6()
        {
            Reproduces_with_eggs bird = new Bird();
            bird.Name = "sozi";
            Assert.Equal("sozi", bird.Name);
        }
    }
}