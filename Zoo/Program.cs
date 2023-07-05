namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Cat cat = new Cat();
            cat.Age = 9;
            cat.Name = "kity";
            cat.JumbOrWalk("Wolk");
            cat.Eat();
            cat.Sleep();
            cat.NumberOflegs(4);
        }
    }
}