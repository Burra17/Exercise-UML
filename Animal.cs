
namespace Exercise_UML
{
    public abstract class Animal // Abstract class to be inherited by specific animal types
    {
        public string Color { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public abstract void MakeSound(); // Abstract method to be implemented by derived classes
    }
}
