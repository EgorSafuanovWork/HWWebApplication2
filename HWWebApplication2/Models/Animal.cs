namespace HWWebApplication2.Models
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public string Sound { get; protected set; }

        public abstract void MakeSound();
    }
    public class Dog : Animal
    {
        public Dog()
        {
            Name = "Собака";
            Sound = "Гав-гав";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Звук: {Sound}");
        }
    }
    public class Cat : Animal
    {
        public Cat()
        {
            Name = "Кіт";
            Sound = "Мяу";
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Звук: {Sound}");
        }
    }
}
