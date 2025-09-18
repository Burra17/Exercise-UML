
namespace Exercise_UML
{
    public class Cat : Animal // Cat class inheriting from Animal abstract class
    {
        public string Temperament { get; set; } // Public property specific to Cat class
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!"); // Implementation of the abstract method
        }
    }
}
